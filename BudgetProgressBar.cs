using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing.Drawing2D;

namespace manaherUI
{
    public class BudgetProgressBar : Control
    {
        private decimal spent = 0;
        private decimal limit = 100;

        public BudgetProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            Height = 28;
        }

        public void SetValues(decimal spent, decimal limit)
        {
            this.spent = spent;
            this.limit = limit <= 0 ? 1 : limit;
            Invalidate(); // просит перерисоваться
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            int radius = Height / 2;

            // фон (пустая полоса)
            using (GraphicsPath bgPath = RoundedRect(bounds, radius))
            using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(230, 230, 230)))
            {
                g.FillPath(bgBrush, bgPath);
            }

            // процент заполнения
            decimal percent = Math.Min(spent / limit, 1);
            int fillWidth = (int)(bounds.Width * percent);

            if (fillWidth > 0)
            {
                Rectangle fillRect = new Rectangle(0, 0, Math.Max(fillWidth, Height), Height - 1);
                Color fillColor = GetColorForPercent(percent);

                using (GraphicsPath fillPath = RoundedRect(fillRect, radius))
                using (SolidBrush fillBrush = new SolidBrush(fillColor))
                {
                    g.FillPath(fillBrush, fillPath);
                }
            }

            // рамка
            using (GraphicsPath borderPath = RoundedRect(bounds, radius))
            using (Pen borderPen = new Pen(Color.FromArgb(200, 200, 200), 1))
            {
                g.DrawPath(borderPen, borderPath);
            }

            // текст в центре
            string text = spent + " / " + limit + " (" + (int)(percent * 100) + "%)";
            using (Font font = new Font("Segoe UI", 9f, FontStyle.Bold))
            {
                SizeF textSize = g.MeasureString(text, font);
                float textX = (Width - textSize.Width) / 2;
                float textY = (Height - textSize.Height) / 2;
                g.DrawString(text, font, Brushes.Black, textX, textY);
            }
        }

        private Color GetColorForPercent(decimal percent)
        {
            if (percent < 0.7m) return Color.FromArgb(76, 175, 80);   // зелёный
            if (percent < 1.0m) return Color.FromArgb(255, 152, 0);   // оранжевый
            return Color.FromArgb(244, 67, 54);                       // красный
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
}
