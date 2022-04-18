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

        Form1 form1; //declaring a container for the passed 'Form1'

        public Form2(Form1 passedForm)
        {
            InitializeComponent();

            form1 = passedForm; // passing the Form1 to form1 var
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
            switch (Subject.Mode)
            {
                case "elec3Btn":
                    form1.elective3.Description = descTxtBx.Text;
                    form1.elective3.Deadline = dedlineTxtBx.Text;
                    break;
                case "elec4Btn":
                    form1.elective4.Description = descTxtBx.Text;
                    form1.elective4.Deadline = dedlineTxtBx.Text;
                    break;
                case "ethicsBtn":
                    form1.ethics.Description = descTxtBx.Text;
                    form1.ethics.Deadline = dedlineTxtBx.Text;
                    break;
                case "networksBtn":
                    form1.networks.Description = descTxtBx.Text;
                    form1.networks.Deadline = dedlineTxtBx.Text;
                    break;
                case "fieldtripsBtn":
                    form1.fieldtrips.Description = descTxtBx.Text;
                    form1.fieldtrips.Deadline = dedlineTxtBx.Text;
                    break;
                case "softwareBtn":
                    form1.software.Description = descTxtBx.Text;
                    form1.software.Deadline = dedlineTxtBx.Text;
                    break;
                case "technoBtn":
                    form1.techno.Description = descTxtBx.Text;
                    form1.techno.Deadline = dedlineTxtBx.Text;
                    break;
                case "tqmBtn":
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
