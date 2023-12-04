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
    public partial class Achievements : Form
    {
        public Achievements()
        {
            InitializeComponent();
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.Enabled = false;
            }
            else if (Facade.instance.Visible)
            {
                Facade.instance.Enabled = false;
            }
            else if (Map.instance.Visible)
            {
                Map.instance.Enabled = false;
            }
            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.Enabled = false;
            }
            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.Enabled = false;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (Bedroom.instance.Visible)
            {
                Bedroom.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Bedroom.instance.achievs_lbl);
                Bedroom.instance.Enabled = true;
            }

            else if (Facade.instance.Visible)
            {
                Facade.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Facade.instance.achievs_lbl);
                Facade.instance.Enabled = true;
            }

            else if (Map.instance.Visible)
            {
                Map.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Map.instance.achievs_lbl);
                Map.instance.Enabled = true;
            }


            else if (CECS_bldg.instance.Visible)
            {
                CECS_bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(CECS_bldg.instance.achievs_lbl);
                CECS_bldg.instance.Enabled = true;
            }

            else if (Old_Bldg.instance.Visible)
            {
                Old_Bldg.instance.achievsClicked = false;
                Bedroom.instance.hoverReset(Old_Bldg.instance.achievs_lbl);
                Old_Bldg.instance.Enabled = true;
            }

            this.Close();
        }
    }
}
