using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Necesario si UIStyles.CreateRoundRectRgn está aquí

namespace ProyectoCRUD_BD
{
    // Heredamos de Button para mantener la funcionalidad básica
    public class RoundedGradientButton : Button
    {
        private bool isHovering = false;
        private bool isMouseDown = false;
        private int cornerRadius = 15;

        // Propiedades de color (Usamos las constantes de UIStyles)
        private Color NormalStartColor = UIStyles.Palette.PrimaryBlue;
        private Color NormalEndColor = UIStyles.Palette.SecondaryBlue;
        private Color HoverStartColor = UIStyles.Palette.SecondaryBlue;
        private Color HoverEndColor = UIStyles.Palette.AccentLight;
        private Color ClickColor = Color.FromArgb(40, 90, 160);

        public RoundedGradientButton()
        {
            // 1. Configuración de Rendimiento y Estilos Iniciales
            ApplyButtonStyles();
        }

        /// <summary>
        /// Aplica la configuración de rendimiento (Double Buffering) y estilos visuales iniciales.
        /// </summary>
        private void ApplyButtonStyles()
        {
            // Habilitar el doble buffering para eliminar el parpadeo (Rendimiento)
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );

            // Configuraciones de estilo iniciales (Diseño)
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Color.White;
            this.Font = UIStyles.Fonts.Semibold;
            this.Height = 35; // Altura estándar
            this.Cursor = Cursors.Hand;
            this.Padding = new Padding(10, 5, 10, 5);
        }

        // El resto del código permanece igual: OnResize, OnMouseEnter, OnPaint, etc.

        // Sobreescribir el evento de redimensionamiento para actualizar la región
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Aplicar el redondeo solo si el botón tiene un tamaño válido
            if (this.Width > cornerRadius * 2 && this.Height > cornerRadius * 2)
            {
                this.Region = System.Drawing.Region.FromHrgn(
                    UIStyles.CreateRoundRectRgn(0, 0, Width, Height, cornerRadius, cornerRadius)
                );
            }
        }

        // Manejo de eventos de ratón para actualizar el estado y forzar el redibujado
        protected override void OnMouseEnter(EventArgs e)
        {
            isHovering = true;
            this.Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHovering = false;
            this.Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            isMouseDown = true;
            this.Invalidate();
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            isMouseDown = false;
            this.Invalidate();
            base.OnMouseUp(mevent);
        }

        // El corazón: Dibujar el botón
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            Color startColor, endColor;

            if (isMouseDown)
            {
                // Usar un color sólido más oscuro al hacer click
                startColor = ClickColor;
                endColor = ClickColor;
            }
            else if (isHovering)
            {
                // Degradado para el estado de Hover
                startColor = HoverStartColor;
                endColor = HoverEndColor;
            }
            else
            {
                // Degradado normal
                startColor = NormalStartColor;
                endColor = NormalEndColor;
            }

            // 1. Dibujar el fondo con el degradado/color
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }

            // 2. Dibujar el texto centrado
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // No llamar a base.OnPaint(pevent) para evitar que el control padre lo pinte.
        }
    }
}