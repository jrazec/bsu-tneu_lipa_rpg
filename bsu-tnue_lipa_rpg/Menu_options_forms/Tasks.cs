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
        //Facade facade = new Facade();
        public Tasks()
        {
            InitializeComponent();
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.Enabled = false;
            }
            else if (Facade.instance.Visible)
            {
                //to fix
                Facade.instance.Enabled = false;
            }
            else if (Map.instance.Visible)
            {
                Map.instance.Enabled = false;
            }
            
        }
        
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.tasksClicked = false;
                Bedroom.instance.hoverReset(Bedroom.instance.tasks_lbl);
                Bedroom.instance.Enabled = true;
            }
            
            else if (Facade.instance.Visible)
            {
                //to fix
                Facade.instance.tasksClicked = false;
                Bedroom.instance.hoverReset(Facade.instance.tasks_lbl);
                Facade.instance.Enabled = true;
            }
            
            else if (Map.instance.Visible)
            {
                Map.instance.tasksClicked = false;
                Bedroom.instance.hoverReset(Map.instance.tasks_lbl);
                Map.instance.Enabled = true;
            }
            
            /*
            else if (CECS_bldg.instance.Visible)
            {
                //
            }
            else if (Old_Bldg.instance.Visible)
            {
                //
            }
            */
            this.Close();
        }
    }
}
