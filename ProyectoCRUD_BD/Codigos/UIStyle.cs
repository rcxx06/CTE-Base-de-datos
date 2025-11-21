using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ProyectoCRUD_BD
{
    public static class UIStyles
    {
        // ======================== CONSTANTES DE ESTILO ========================
        public static class Palette
        {
            public static readonly Color PrimaryBlue = Color.FromArgb(60, 130, 210);
            public static readonly Color SecondaryBlue = Color.FromArgb(85, 160, 240);
            public static readonly Color AccentLight = Color.FromArgb(135, 206, 250);
            public static readonly Color ClickDark = Color.FromArgb(40, 90, 160);

            public static readonly Color TextDark = Color.FromArgb(50, 50, 50);
            public static readonly Color TextMuted = Color.Gray;
            public static readonly Color BackgroundHover = Color.FromArgb(240, 250, 255);
            public static readonly Color GridBorder = Color.FromArgb(220, 220, 220);
            public static readonly Color GroupBoxBorder = Color.FromArgb(35, 65, 110);
        }

        // ======================== CLASE DE ESTADO DE BOTÓN (Patrón Tag) ========================
        private class ButtonState
        {
            public Color StartColor { get; set; }
            public Color EndColor { get; set; }
            public bool IsHovering { get; set; } = false;
            public bool IsMouseDown { get; set; } = false;

            public Color NormalStart { get; set; } = Palette.PrimaryBlue;
            public Color NormalEnd { get; set; } = Palette.SecondaryBlue;
            public Color HoverStart { get; set; } = Palette.SecondaryBlue;
            public Color HoverEnd { get; set; } = Palette.AccentLight;
            public Color ClickColor { get; set; } = Palette.ClickDark;
        }



        public static class Fonts
        {
            public static readonly Font Base = new Font("Segoe UI", 10, FontStyle.Regular);
            public static readonly Font Semibold = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            public static readonly Font SmallBold = new Font("Segoe UI", 8, FontStyle.Bold);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse);

        // ======================== FORM ========================
        public static void ApplyFormStyle(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Padding = new Padding(10);
            form.Resize += (s, e) => form.Invalidate();

            form.Paint += (s, e) =>
            {
                using var brush = new LinearGradientBrush(
                    form.ClientRectangle,
                    Color.FromArgb(70, 130, 180),
                    Palette.AccentLight,
                    LinearGradientMode.Vertical
                );
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, form.ClientRectangle);
            };
        }

        // ======================== ALERTAS MODERNAS ========================

        public static void ShowAlert(string message, int duration = 1500)
        {
            AlertForm alert = new AlertForm();

            Label lbl = new Label()
            {
                Text = message,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 10),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = Color.White
            };

            alert.Controls.Add(lbl);

            alert.Shown += async (s, e) =>
            {
                for (double i = 0; i <= 1; i += 0.08)
                {
                    alert.Opacity = i;
                    await Task.Delay(25);
                }

                await Task.Delay(duration);

                for (double i = 1; i >= 0; i -= 0.08)
                {
                    alert.Opacity = i;
                    await Task.Delay(25);
                }

                alert.Close();
                alert.Dispose();
            };

            alert.Show();
        }


        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }




        // ======================== BOTONES REDONDEADOS CON DEGRADADO ========================
        public static void StyleButton(Button btn, int height = 35)
        {
            const int cornerRadius = 15;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = Fonts.Semibold;
            btn.Height = height;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 5, 10, 5);

            ButtonState state = new ButtonState();
            btn.Tag = state;
            state.StartColor = state.NormalStart;
            state.EndColor = state.NormalEnd;

            if (btn.Width > cornerRadius * 2 && btn.Height > cornerRadius * 2)
            {
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, cornerRadius, cornerRadius));
            }

            btn.Paint += Button_Paint;

            btn.MouseEnter += (s, e) => { state.IsHovering = true; UpdateColors((Button)s, state); };
            btn.MouseLeave += (s, e) => { state.IsHovering = false; UpdateColors((Button)s, state); };
            btn.MouseDown += (s, e) => { state.IsMouseDown = true; UpdateColors((Button)s, state); };
            btn.MouseUp += (s, e) => {
                state.IsMouseDown = false;
                if (((Button)s).ClientRectangle.Contains(((Button)s).PointToClient(Cursor.Position)))
                    state.IsHovering = true;
                UpdateColors((Button)s, state);
            };

            btn.Resize += (s, e) =>
            {
                if (btn.Width > cornerRadius * 2 && btn.Height > cornerRadius * 2)
                    btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, cornerRadius, cornerRadius));
                btn.Invalidate();
            };
        }

        private static void Button_Paint(object sender, PaintEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Tag is ButtonState state)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = b.ClientRectangle;
                using (LinearGradientBrush brush = new LinearGradientBrush(rect, state.StartColor, state.EndColor, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, rect);
                }
                TextRenderer.DrawText(g, b.Text, b.Font, rect, b.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private static void UpdateColors(Button b, ButtonState state)
        {
            if (state.IsMouseDown)
            {
                state.StartColor = state.ClickColor;
                state.EndColor = state.ClickColor;
            }
            else if (state.IsHovering)
            {
                state.StartColor = state.HoverStart;
                state.EndColor = state.HoverEnd;
            }
            else
            {
                state.StartColor = state.NormalStart;
                state.EndColor = state.NormalEnd;
            }
            b.Invalidate();
        }

        // ======================== TEXTBOX ========================
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;      // Sin borde estándar
            txt.BackColor = Color.White;
            txt.ForeColor = Palette.TextDark;
            txt.Font = Fonts.Base;
            txt.Padding = new Padding(1);            // NO cambia tamaño

            // Agregar línea inferior estilo Material
            txt.Paint += (s, e) =>
            {
                using Pen p = new Pen(Color.Gray, 1);
                e.Graphics.DrawLine(p, 0, txt.Height - 1, txt.Width, txt.Height - 1);
            };

            // Hover / Focus sin mover nada
            txt.Enter += (s, e) => txt.Invalidate();
            txt.Leave += (s, e) => txt.Invalidate();

            txt.Paint += (s, e) =>
            {
                Color lineColor = txt.Focused ? Palette.PrimaryBlue : Color.Gray;

                using Pen p = new Pen(lineColor, txt.Focused ? 2 : 1)
                {
                    Alignment = PenAlignment.Inset
                };

                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawLine(p, 0, txt.Height - 1, txt.Width, txt.Height - 1);
            };
        }



        // ======================== LABEL ========================
        public static void StyleLabel(Label lbl)
        {
            lbl.Font = Fonts.Base;
            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.Transparent;
            lbl.AutoSize = true;

            lbl.AutoSize = true; // Mantiene su tamaño original
            lbl.Margin = new Padding(0, -3, 0, 0); // Hace que se vea un poco más arriba
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Diseño bonito

            // Elevar el label un poco
            lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - 9);
        }



        // ======================== FLOATING LABEL ========================
        public static void ApplyFloatingLabel(TextBox txt, Label lbl)
        {
            StyleTextBox(txt);
            StyleLabel(lbl);

            lbl.AutoSize = true;
            lbl.Location = new Point(txt.Left + 5, txt.Top + 8);

            void UpdateLabel()
            {
                if (txt.Focused || !string.IsNullOrEmpty(txt.Text))
                {
                    lbl.Font = Fonts.SmallBold;
                    lbl.ForeColor = Color.FromArgb(30, 60, 120);
                    lbl.Top = txt.Top - lbl.Height - 2;
                }
                else
                {
                    lbl.Font = Fonts.Base;
                    lbl.ForeColor = Color.White; // etiqueta siempre blanca
                    lbl.Top = txt.Top + 8;
                }
            }

            txt.GotFocus += (s, e) => UpdateLabel();
            txt.LostFocus += (s, e) => UpdateLabel();
            txt.TextChanged += (s, e) => UpdateLabel();

            UpdateLabel();
        }

        // ======================== DATAGRID ========================
        public static void StyleDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowTemplate.Height = 30;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Palette.PrimaryBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = Fonts.Semibold;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.SelectionBackColor = Palette.SecondaryBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = Fonts.Base;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.GridColor = Palette.GridBorder;
        }

        // ======================== COMBOBOX ========================
        public static void StyleComboBox(ComboBox cb)
        {
            cb.Font = Fonts.Base;
            cb.BackColor = Color.White;
            cb.FlatStyle = FlatStyle.Flat;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.ForeColor = Palette.TextDark;
        }

        // ======================== DATETIMEPICKER ========================
        public static void StyleDateTimePicker(DateTimePicker dtp)
        {
            dtp.Font = Fonts.Base;
            dtp.CalendarFont = new Font(Fonts.Base.FontFamily, 9);
            dtp.BackColor = Color.White;
            dtp.ForeColor = Palette.TextDark;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
        }

        // ======================== GROUPBOX MODERNO ========================
        public static void StyleGroupBox(GroupBox gb)
        {
            gb.Font = Fonts.Semibold;
            gb.ForeColor = Color.White; // título blanco
            gb.BackColor = Color.Transparent;
            gb.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (LinearGradientBrush bgBrush = new LinearGradientBrush(
                    gb.ClientRectangle,
                    Color.FromArgb(60, 130, 210, 220),
                    Color.FromArgb(100, 85, 160, 240),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(bgBrush, gb.ClientRectangle);
                }

                using (Pen borderPen = new Pen(Palette.PrimaryBlue, 1.8f))
                {
                    Rectangle rect = new Rectangle(0, 10, gb.Width - 1, gb.Height - 1);
                    e.Graphics.DrawRectangle(borderPen, rect);
                }

                Size textSize = TextRenderer.MeasureText(gb.Text, gb.Font);
                Rectangle textRect = new Rectangle(10, 0, textSize.Width + 10, textSize.Height);
                using (SolidBrush titleBrush = new SolidBrush(Palette.PrimaryBlue))
                {
                    e.Graphics.FillRectangle(titleBrush, textRect);
                }
                TextRenderer.DrawText(e.Graphics, gb.Text, gb.Font, textRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        // ======================== APLICAR ESTILO A TODOS LOS CONTROLES ========================
        public static void ApplyAllStyles(Form form)
        {
            ApplyFormStyle(form);

            void ApplyStyleRecursively(Control control)
            {
                switch (control)
                {
                    case Button btn: StyleButton(btn, 35); break;
                    case Label lbl: StyleLabel(lbl); break;
                    case TextBox txt: StyleTextBox(txt); break;
                    case DataGridView dgv: StyleDataGrid(dgv); break;
                    case ComboBox cb: StyleComboBox(cb); break;
                    case DateTimePicker dtp: StyleDateTimePicker(dtp); break;
                    case GroupBox gb: StyleGroupBox(gb); break;
                }

                if (control.HasChildren)
                    foreach (Control child in control.Controls)
                        ApplyStyleRecursively(child);
            }

            foreach (Control control in form.Controls)
                ApplyStyleRecursively(control);
        }
    }
}
