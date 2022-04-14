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
    public partial class Form1 : Form
    {
        public Subject elective3 = new Subject();
        public Subject elective4 = new Subject();
        public Subject ethics = new Subject();
        public Subject networks = new Subject();
        public Subject fieldtrips = new Subject();
        public Subject software = new Subject();
        public Subject techno = new Subject();
        public Subject tqm = new Subject();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mode.Mode = btn.Name;

            Form2 form2 = new Form2();
            form2.Confirmed += HasBeenConfirmed;
            form2.Show();
        }

        private void HasBeenConfirmed()
        {
            switch (mode.Mode)
            {
                case "elec3AddBtn":
                    elec3DescLabel.Text = elective3.Description;
                    elec3DedlineLabel.Text = elective3.Deadline;
                    break;
                case "elec4AddBtn":
                    elec4DescLabel.Text = elective4.Description;
                    elec4DedlineLabel.Text = elective4.Deadline;
                    break;
                case "ethicsAddBtn":
                    ethicsDescLabel.Text = ethics.Description;
                    ethicsDedlineLabel.Text = ethics.Deadline;
                    break;
                case "networksAddBtn":
                    networksDescLabel.Text = networks.Description;
                    networksDedlineLabel.Text = networks.Deadline;
                    break;
                case "fieldtripsAddBtn":
                    fieldtripsDescLabel.Text = fieldtrips.Description;
                    fieldtripsDedlineLabel.Text = fieldtrips.Deadline;
                    break;
                case "softwareAddBtn":
                    softwareDescLabel.Text = software.Description;
                    softwareDedlineLabel.Text = software.Deadline;
                    break;
                case "technoAddBtn":
                    technoDescLabel.Text = techno.Description;
                    technoDedlineLabel.Text = techno.Deadline;
                    break;
                case "tqmAddBtn":
                    tqmDescLabel.Text = tqm.Description;
                    tqmDedlineLabel.Text = tqm.Deadline;
                    break;

                default:
                    break;
            }
        }
    }
}
