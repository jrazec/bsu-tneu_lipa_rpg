using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg
{
    public partial class messagebox : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        public messagebox()
        {
            InitializeComponent();


        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            const int WM_NCPAINT = 0x85;

            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if (hdc != IntPtr.Zero)
                {
                    using (Graphics g = Graphics.FromHdc(hdc))
                    {

                        using (Brush brush = new SolidBrush(Color.Blue))
                        {
                            Rectangle rect = new Rectangle(0, 0, this.Width, SystemInformation.CaptionHeight);
                            g.FillRectangle(brush, rect);
                        }
                    }

                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }




        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

 

        private void messagebox_Load(object sender, EventArgs e)
        {
           
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;

           
            this.TransparencyKey = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}