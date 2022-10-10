using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerFor77ro
{
    public partial class MainForm : Form
    {
        private static System.Timers.Timer aTimer;

        private bool pickingColor = false;

        private int mousePosX;
        private int mousePosY;
        private Color screenColor;

        public MainForm ()
        {
            InitializeComponent();

            buffer_graphics = Graphics.FromImage(buffer);

            Hook.GlobalEvents().MouseMove += (s, e) =>
            {
                mousePosX = (int)e.X;
                mousePosY = (int)e.Y;

                MousePosValue_Update();

                screenColor = GetScreenColor(mousePosX, mousePosY);
                PickedColorPanel.BackColor = screenColor;
            };
        }

        private void PickColorBtn_Click (object sender, EventArgs e)
        {
            pickingColor = true;
            PickColorBtn.ForeColor = Color.Red;
        }

        private void MousePosValue_Update ()
        {
            MousePosValue.Invoke((MethodInvoker)delegate ()
            {
                MousePosValue.Text = String.Format("({0}, {1})", mousePosX, mousePosY);
            });
        }

        // 임시 버퍼
        private Bitmap buffer = new Bitmap(1, 1);
        // 임시 버퍼의 graphic 타입
        private Graphics buffer_graphics = null;

        private Color GetScreenColor (int x, int y)
        {
            // Mouse 위치의 색을 추출한다.
            buffer_graphics.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            // Pixel 값을 리턴한다.
            return buffer.GetPixel(0, 0);
        }
    }
}
