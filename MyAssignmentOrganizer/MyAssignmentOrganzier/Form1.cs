using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssignmentOrganzier
{
    public partial class Form1 : Form
    {
        private const string _path = @"C:\Users\franc\source\repos\MyAssignmentOrganzier\MyAssignmentOrganizer\MyAssignmentOrganzier\json\Data.json";

        // INSTATIATE AN 'ALL' CLASS
        public All allSubjects = new All();
        // INSTANTIATE 'SUBJECT' CLASS
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
            // READ CONTENTS OF JSON FILE AND SHOW THEM
            string jsonFromFile = File.ReadAllText(_path);
            allSubjects = JsonConvert.DeserializeObject<All>(jsonFromFile);

            elec3DescLabel.Text = allSubjects.elec3_desc;
            elec3DedlineLabel.Text = allSubjects.elec3_dline;

            elec4DescLabel.Text = allSubjects.elec4_desc;
            elec4DedlineLabel.Text = allSubjects.elec4_dline;

            ethicsDescLabel.Text = allSubjects.ethics_desc;
            ethicsDedlineLabel.Text = allSubjects.ethics_dline;

            networksDescLabel.Text = allSubjects.networks_desc;
            networksDedlineLabel.Text = allSubjects.networks_dline;

            fieldtripsDescLabel.Text = allSubjects.fieldtrips_desc;
            fieldtripsDedlineLabel.Text = allSubjects.fieldtrips_dline;

            softwareDescLabel.Text = allSubjects.software_desc;
            softwareDedlineLabel.Text = allSubjects.software_dline;

            technoDescLabel.Text = allSubjects.techno_desc;
            technoDedlineLabel.Text = allSubjects.techno_dline;

            tqmDescLabel.Text = allSubjects.tqm_desc;
            tqmDedlineLabel.Text = allSubjects.tqm_dline;

            //STYLING THE DESCRIPTION AND DEADLINE LABELS
            foreach (Label label in this.tableLayoutPanel1.Controls.OfType<Label>())
            {
                if(Convert.ToString(label.Tag) == "descriptionLabels" || Convert.ToString(label.Tag) == "deadlineLabels")
                {
                    label.Font = new Font("Century Gothic",10);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Subject.Mode = btn.Tag.ToString();

            Form2 form2 = new Form2(this);
            form2.Confirmed += HasBeenConfirmed;
            form2.Show();
        }

        private void finishedBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Subject.Mode = btn.Tag.ToString();

            switch (Subject.Mode)
            {
                case "elec3Btn":
                    elec3DescLabel.Text = "";
                    elec3DedlineLabel.Text = "";
                    break;
                case "elec4Btn":
                    elec4DescLabel.Text = "";
                    elec4DedlineLabel.Text = "";
                    break;
                case "ethicsBtn":
                    ethicsDescLabel.Text = "";
                    ethicsDedlineLabel.Text = "";
                    break;
                case "networksBtn":
                    networksDescLabel.Text = "";
                    networksDedlineLabel.Text = "";
                    break;
                case "fieldtripsBtn":
                    fieldtripsDescLabel.Text = "";
                    fieldtripsDedlineLabel.Text = "";
                    break;
                case "softwareBtn":
                    softwareDescLabel.Text = "";
                    softwareDedlineLabel.Text = "";
                    break;
                case "technoBtn":
                    technoDescLabel.Text = "";
                    technoDedlineLabel.Text = "";
                    break;
                case "tqmBtn":
                    tqmDescLabel.Text = "";
                    tqmDedlineLabel.Text = "";
                    break;

                default:
                    break;
            }
            Save();
        }

        private void HasBeenConfirmed()
        {
            switch (Subject.Mode)
            {
                case "elec3Btn":
                    elec3DescLabel.Text = elective3.Description;
                    elec3DedlineLabel.Text = elective3.Deadline;
                    break;
                case "elec4Btn":
                    elec4DescLabel.Text = elective4.Description;
                    elec4DedlineLabel.Text = elective4.Deadline;
                    break;
                case "ethicsBtn":
                    ethicsDescLabel.Text = ethics.Description;
                    ethicsDedlineLabel.Text = ethics.Deadline;
                    break;
                case "networksBtn":
                    networksDescLabel.Text = networks.Description;
                    networksDedlineLabel.Text = networks.Deadline;
                    break;
                case "fieldtripsBtn":
                    fieldtripsDescLabel.Text = fieldtrips.Description;
                    fieldtripsDedlineLabel.Text = fieldtrips.Deadline;
                    break;
                case "softwareBtn":
                    softwareDescLabel.Text = software.Description;
                    softwareDedlineLabel.Text = software.Deadline;
                    break;
                case "technoBtn":
                    technoDescLabel.Text = techno.Description;
                    technoDedlineLabel.Text = techno.Deadline;
                    break;
                case "tqmBtn":
                    tqmDescLabel.Text = tqm.Description;
                    tqmDedlineLabel.Text = tqm.Deadline;
                    break;

                default:
                    break;
            }
            Save();
        }

        private void Save()
        {
            switch (Subject.Mode)
            {
                case "elec3Btn":
                    allSubjects.elec3_desc = elec3DescLabel.Text;
                    allSubjects.elec3_dline = elec3DedlineLabel.Text;
                    break;
                case "elec4Btn":
                    allSubjects.elec4_desc = elec4DescLabel.Text;
                    allSubjects.elec4_dline = elec4DedlineLabel.Text;
                    break;
                case "ethicsBtn":
                    allSubjects.ethics_desc = ethicsDescLabel.Text;
                    allSubjects.ethics_dline = ethicsDedlineLabel.Text;
                    break;
                case "networksBtn":
                    allSubjects.networks_desc = networksDescLabel.Text;
                    allSubjects.networks_dline = networksDedlineLabel.Text;
                    break;
                case "fieldtripsBtn":
                    allSubjects.fieldtrips_desc = fieldtripsDescLabel.Text;
                    allSubjects.fieldtrips_dline = fieldtripsDedlineLabel.Text;
                    break;
                case "softwareBtn":
                    allSubjects.software_desc = softwareDescLabel.Text;
                    allSubjects.software_dline = softwareDedlineLabel.Text;
                    break;
                case "technoBtn":
                    allSubjects.techno_desc = technoDescLabel.Text;
                    allSubjects.techno_dline = technoDedlineLabel.Text;
                    break;
                case "tqmBtn":
                    allSubjects.tqm_desc = tqmDescLabel.Text;
                    allSubjects.tqm_dline = tqmDedlineLabel.Text;
                    break;

                default:
                    break;
            }

            string jsonToWrite = JsonConvert.SerializeObject(allSubjects, Formatting.Indented);

            StreamWriter createJSON = File.CreateText(_path);
            createJSON.Write(jsonToWrite);
            createJSON.Close();
        }
    }
}
