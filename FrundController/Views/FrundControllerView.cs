using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

using FrundController.Shapes;

namespace FrundController.Views
{
    public partial class FrundControllerView : UserControl
    {
        FrundControllerClient frundController;

        MovableCircle circle = new MovableCircle();
        Timer reDrawTimer = new Timer();

        enum CircleMoveState
        {
            NotSelected,
            Selected
        }

        CircleMoveState state = CircleMoveState.NotSelected;

        public FrundControllerView()
        {
            InitializeComponent();
            widgetsInit();

            circle.X = 75;
            circle.Y = 75;
            circle.Radius = 10;

            reDrawTimer.Interval = 50;
            reDrawTimer.Tick += ReDrawTimer_Tick;
            reDrawTimer.Start();
        }

        public void setFrundControllerClient(ref FrundControllerClient client)
        {
            frundController = client;
        }

        private void ReDrawTimer_Tick(object sender, EventArgs e)
        {
            reDraw();
        }

        private void widgetsInit()
        {
            selectModelBox.Items.AddRange(new string[] { "Универсальное движение", "Движение вперед/назад", "Движение вправо/влево" });
            selectModelBox.SelectedIndex = 0;

            ViewLibrary.ViewStyler.styleGrid(ref additionalParamsGrid);
            additionalParamsGrid.RowCount = 3;
            additionalParamsGrid[0, 0].Value = "Высота шага";
            additionalParamsGrid[1, 0].Value = 0.1;
            additionalParamsGrid[0, 1].Value = "Длина шага";
            additionalParamsGrid[1, 1].Value = 0.2;
            additionalParamsGrid[0, 2].Value = "Высота центра масс";
            additionalParamsGrid[1, 2].Value = 0.6;
        }

        // Перерисовка области
        void reDraw()
        {
            Bitmap bmp =
                new Bitmap(velocityControlCanvas.Width, velocityControlCanvas.Height, velocityControlCanvas.CreateGraphics());
            Graphics g = Graphics.FromImage(bmp);

            // Рисование осей
            Pen pen = new Pen(Brushes.Gray, 2);
            pen.DashStyle = DashStyle.Dash;

            g.DrawLine(pen, 75, 0, 75, 150);
            g.DrawLine(pen, 0, 75, 150, 75);

            drawCircle(ref g);

            velocityControlCanvas.Image = bmp;
            velocityControlCanvas.Refresh();
        }

        void drawCircle(ref Graphics g)
        {
            g.FillEllipse(System.Drawing.Brushes.Blue, circle.X - circle.Radius, circle.Y - circle.Radius, circle.Radius * 2, circle.Radius * 2);
        }

        private void velocityControlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(Math.Abs(e.X - circle.X) < circle.Radius && Math.Abs(e.Y - circle.Y) < circle.Radius)
                {
                    // мы нажали на кружок
                    state = CircleMoveState.Selected;
                }
                else
                {
                    state = CircleMoveState.NotSelected;
                }
            }
        }

        private void velocityControlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(state == CircleMoveState.Selected)
            {
                // двигаем
                circle.X = e.X;
                circle.Y = e.Y;

                trackVelocityX.Value = 150 - e.Y;
                trackVelocityY.Value = e.X;
                lblVelocityX.Text = trackVelocityX.Value.ToString();
                lblVelocityY.Text = trackVelocityY.Value.ToString();
            }
        }

        private void velocityControlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            state = CircleMoveState.NotSelected;
        }

        private void trackVelocityX_Scroll(object sender, EventArgs e)
        {
            circle.Y = 150 - trackVelocityX.Value;
            lblVelocityX.Text = trackVelocityX.Value.ToString();
        }

        private void trackVelocityY_Scroll(object sender, EventArgs e)
        {
            circle.X = trackVelocityY.Value;
            lblVelocityY.Text = trackVelocityY.Value.ToString();
        }

        private void buttonZeroing_Click(object sender, EventArgs e)
        {
            circle.X = 75;
            circle.Y = 75;
            trackVelocityX.Value = 75;
            trackVelocityY.Value = 75;
            lblVelocityX.Text = 75.ToString();
            lblVelocityY.Text = 75.ToString();
        }
    }
}
