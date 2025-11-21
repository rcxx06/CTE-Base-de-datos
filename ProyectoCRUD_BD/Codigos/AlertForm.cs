using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class AlertForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int CornerRadius { get; set; } = 20;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color Color1 { get; set; } = Color.FromArgb(52, 152, 219);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color Color2 { get; set; } = Color.FromArgb(41, 128, 185);
    public AlertForm()
    {
        FormBorderStyle = FormBorderStyle.None;
        ShowInTaskbar = false;
        TopMost = true;
        Width = 300;
        Height = 70;
        StartPosition = FormStartPosition.CenterScreen;
        Opacity = 0;

        // 🔥 Activar estilos invisibles (sí permite SetStyle)
        SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.UserPaint, true);

        // 🔥 Transparencia real
        BackColor = Color.Magenta;
        TransparencyKey = Color.Magenta;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width, Height);

        using (GraphicsPath path = RoundedRect(rect, CornerRadius))
        using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color1, Color2, LinearGradientMode.Vertical))
        {
            e.Graphics.FillPath(brush, path);
        }

        base.OnPaint(e);
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
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
}
