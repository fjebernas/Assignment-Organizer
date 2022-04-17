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
            SubmitData();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SubmitData();
            }
        }

        private void SubmitData()
        {
            Form1 form1 = new Form1();

            switch (Tools.AddMode)
            {
                case "elec3AddBtn":
                    form1.elective3.Description = descTxtBx.Text;
                    form1.elective3.Deadline = dedlineTxtBx.Text;
                    break;
                case "elec4AddBtn":
                    form1.elective4.Description = descTxtBx.Text;
                    form1.elective4.Deadline = dedlineTxtBx.Text;
                    break;
                case "ethicsAddBtn":
                    form1.ethics.Description = descTxtBx.Text;
                    form1.ethics.Deadline = dedlineTxtBx.Text;
                    break;
                case "networksAddBtn":
                    form1.networks.Description = descTxtBx.Text;
                    form1.networks.Deadline = dedlineTxtBx.Text;
                    break;
                case "fieldtripsAddBtn":
                    form1.fieldtrips.Description = descTxtBx.Text;
                    form1.fieldtrips.Deadline = dedlineTxtBx.Text;
                    break;
                case "softwareAddBtn":
                    form1.software.Description = descTxtBx.Text;
                    form1.software.Deadline = dedlineTxtBx.Text;
                    break;
                case "technoAddBtn":
                    form1.techno.Description = descTxtBx.Text;
                    form1.techno.Deadline = dedlineTxtBx.Text;
                    break;
                case "tqmAddBtn":
                    form1.tqm.Description = descTxtBx.Text;
                    form1.tqm.Deadline = dedlineTxtBx.Text;
                    break;

                default:
                    break;
            }

            if (Confirmed != null)
            {
                Confirmed();
            }

            this.Close();
        }
    }
}
