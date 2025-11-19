using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoCRUD_BD
{
    public static class UIStyles
    {
        // ======================== FORM ========================
        public static void ApplyFormStyle(Form form)
        {
            form.BackColor = Color.FromArgb(220, 235, 250);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Resize += (s, e) => form.Invalidate(); // Redibuja degradado al cambiar tamaño

            form.Paint += (s, e) =>
            {
                using LinearGradientBrush brush = new LinearGradientBrush(
                    form.ClientRectangle,
                    Color.FromArgb(235, 245, 255),
                    Color.FromArgb(200, 220, 240),
                    90f
                );
                e.Graphics.FillRectangle(brush, form.ClientRectangle);
            };
        }

        // ======================== BUTTON ========================
        public static void StyleButton(Button btn, int height = 45)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(70, 130, 180);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = height;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(100, 160, 220);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(70, 130, 180);
            };
        }

        // ======================== TEXTBOX ========================
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.Font = new Font("Segoe UI", 10);
            txt.Margin = new Padding(3, 5, 3, 5);

            txt.Enter += (s, e) => txt.BackColor = Color.FromArgb(240, 250, 255);
            txt.Leave += (s, e) => txt.BackColor = Color.White;
        }

        // ======================== LABEL ========================
        public static void StyleLabel(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(40, 70, 120);
        }

        // ======================== DATAGRID ========================
        public static void StyleDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 160, 220);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ======================== COMBOBOX ========================
        public static void StyleComboBox(ComboBox cb)
        {
            cb.Font = new Font("Segoe UI", 10);
            cb.BackColor = Color.White;
            cb.FlatStyle = FlatStyle.Flat;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.ForeColor = Color.FromArgb(50, 50, 50);
        }

        // ======================== DATETIMEPICKER ========================
        public static void StyleDateTimePicker(DateTimePicker dtp)
        {
            dtp.Font = new Font("Segoe UI", 10);
            dtp.CalendarFont = new Font("Segoe UI", 9);
            dtp.BackColor = Color.White;
            dtp.ForeColor = Color.FromArgb(50, 50, 50);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
        }

        // ======================== GRUPO ========================
        public static void StyleGroupBox(GroupBox gb)
        {
            gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gb.ForeColor = Color.FromArgb(40, 70, 120);
        }

        // ======================== APLICAR ESTILO A TODOS LOS CONTROLES ========================
        public static void ApplyAllStyles(Form form)
        {
            ApplyFormStyle(form);

            foreach (Control control in form.Controls)
            {
                switch (control)
                {
                    case Button btn: StyleButton(btn); break;
                    case TextBox txt: StyleTextBox(txt); break;
                    case Label lbl: StyleLabel(lbl); break;
                    case DataGridView dgv: StyleDataGrid(dgv); break;
                    case ComboBox cb: StyleComboBox(cb); break;
                    case DateTimePicker dtp: StyleDateTimePicker(dtp); break;
                    case GroupBox gb:
                        StyleGroupBox(gb);
                        foreach (Control sub in gb.Controls)
                        {
                            if (sub is Button b) StyleButton(b);
                            if (sub is TextBox t) StyleTextBox(t);
                            if (sub is Label l) StyleLabel(l);
                            if (sub is DataGridView d) StyleDataGrid(d);
                            if (sub is ComboBox c) StyleComboBox(c);
                            if (sub is DateTimePicker dt) StyleDateTimePicker(dt);
                        }
                        break;
                }
            }
        }

        // ======================== DASHBOARD ========================
        public static void ApplyDashboardStyles(Form dashboard)
        {
            var panelMenu = dashboard.Controls["panelMenu"] as Panel;
            var panelContenido = dashboard.Controls["controladorForms"] as Panel;

            if (panelMenu != null)
            {
                panelMenu.BackColor = Color.FromArgb(50, 100, 200);
                panelMenu.Resize += (s, e) => panelMenu.Invalidate(); // responsive

                foreach (Control ctrl in panelMenu.Controls)
                    if (ctrl is Button btn) StyleButton(btn, 40);
            }

            if (panelContenido != null)
                panelContenido.BackColor = Color.WhiteSmoke;
        }
    }
}
