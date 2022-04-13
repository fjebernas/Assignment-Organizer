using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssignmentOrganzier
{
    public partial class Form2 : Form
    {
        public delegate void OnConfirm();
        public OnConfirm Confirmed;

        public Form2()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            switch (subject.Mode)
            {
                case "elec3AddBtn":
                    elective3.Description = descTxtBx.Text;
                    elective3.Deadline = dedlineTxtBx.Text;
                    break;
                case "elec4AddBtn":
                    elective4.Description = descTxtBx.Text;
                    elective4.Deadline = dedlineTxtBx.Text;
                    break;
                case "ethicsAddBtn":
                    ethics.Description = descTxtBx.Text;
                    ethics.Deadline = dedlineTxtBx.Text;
                    break;
                case "networksAddBtn":
                    networks.Description = descTxtBx.Text;
                    networks.Deadline = dedlineTxtBx.Text;
                    break;
                case "fieldtripsAddBtn":
                    fieldtrips.Description = descTxtBx.Text;
                    fieldtrips.Deadline = dedlineTxtBx.Text;
                    break;
                case "softwareAddBtn":
                    software.Description = descTxtBx.Text;
                    software.Deadline = dedlineTxtBx.Text;
                    break;
                case "technoAddBtn":
                    techno.Description = descTxtBx.Text;
                    techno.Deadline = dedlineTxtBx.Text;
                    break;
                case "tqmAddBtn":
                    tqm.Description = descTxtBx.Text;
                    tqm.Deadline = dedlineTxtBx.Text;
                    break;

                default:
                    break;
            }
            

            if(Confirmed != null)
            {
                Confirmed();
            }

            this.Close();
        }
    }
}
