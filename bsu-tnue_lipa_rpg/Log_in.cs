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
    public partial class Log_in : Form
    {
        public static Log_in instance;
        public Log_in()
        {
            InitializeComponent();
            instance = this; 
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 mainWindow = new Form1();//not sure here, seems leik wrong
            mainWindow.Show();
        }
    }
}
