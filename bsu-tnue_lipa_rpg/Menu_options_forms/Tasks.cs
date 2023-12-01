using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.Menu_options_forms
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.Enabled = false;
            }
            
        }
        Facade facade = new Facade();
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.tasksClicked = false;
                Bedroom.instance.hoverReset(Bedroom.instance.tasks_lbl);
                Bedroom.instance.Enabled = true;
            }

            else if (facade.Visible)
            {
                //
            }

            else if (Map.instance.Visible)
            {
                //
            }

            else if (CECS_bldg.instance.Visible)
            {
                //
            }
            else if (Old_Bldg.instance.Visible)
            {
                //
            }
            
            this.Close();
        }
    }
}
