using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssignmentOrganzier
{
    public partial class Form1 : Form
    {
        string _path = @"C:\Users\franc\source\repos\MyAssignmentOrganzier\MyAssignmentOrganizer\MyAssignmentOrganzier\json\Data.json";
        
        All allSubjects = new All();

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
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mode.Mode = btn.Name;

            Form2 form2 = new Form2();
            form2.Confirmed += HasBeenConfirmed;
            form2.Show();
        }

        private void finishedBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "elec3FinishedBtn":
                    elec3DescLabel.Text = "";
                    elec3DedlineLabel.Text = "";
                    break;
                case "elec4FinishedBtn":
                    elec4DescLabel.Text = "";
                    elec4DedlineLabel.Text = "";
                    break;
                case "ethicsFinishedBtn":
                    ethicsDescLabel.Text = "";
                    ethicsDedlineLabel.Text = "";
                    break;
                case "networksFinishedBtn":
                    networksDescLabel.Text = "";
                    networksDedlineLabel.Text = "";
                    break;
                case "fieldtripsFinishedBtn":
                    fieldtripsDescLabel.Text = "";
                    fieldtripsDedlineLabel.Text = "";
                    break;
                case "softwareFinishedBtn":
                    softwareDescLabel.Text = "";
                    softwareDedlineLabel.Text = "";
                    break;
                case "technoFinishedBtn":
                    technoDescLabel.Text = "";
                    technoDedlineLabel.Text = "";
                    break;
                case "tqmFinishedBtn":
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
            Save();
        }

        private void Save()
        {
            allSubjects.elec3_desc = elec3DescLabel.Text;
            allSubjects.elec3_dline = elec3DedlineLabel.Text;

            allSubjects.elec4_desc = elec4DescLabel.Text;
            allSubjects.elec4_dline = elec4DedlineLabel.Text;

            allSubjects.ethics_desc = ethicsDescLabel.Text;
            allSubjects.ethics_dline = ethicsDedlineLabel.Text;

            allSubjects.networks_desc = networksDescLabel.Text;
            allSubjects.networks_dline = networksDedlineLabel.Text;

            allSubjects.fieldtrips_desc = fieldtripsDescLabel.Text;
            allSubjects.fieldtrips_dline = fieldtripsDedlineLabel.Text;

            allSubjects.software_desc = softwareDescLabel.Text;
            allSubjects.software_dline = softwareDedlineLabel.Text;

            allSubjects.techno_desc = technoDescLabel.Text;
            allSubjects.techno_dline = technoDedlineLabel.Text;

            allSubjects.tqm_desc = tqmDescLabel.Text;
            allSubjects.tqm_dline = tqmDedlineLabel.Text;

            string jsonToWrite = JsonConvert.SerializeObject(allSubjects, Formatting.Indented);

            StreamWriter createJSON = File.CreateText(_path);
            createJSON.Write(jsonToWrite);
            createJSON.Close();
        }
    }
}
