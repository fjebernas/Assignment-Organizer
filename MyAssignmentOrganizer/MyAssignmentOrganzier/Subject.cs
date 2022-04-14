using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignmentOrganzier
{
    public class Subject
    {
        private static string description;
        private static string deadline;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
    }

    public partial class mode
    {
        public static string Mode;
    }

    public class All
    {
        public string elec3_desc { get; set; }
        public string elec3_dline { get; set; }

        public string elec4_desc { get; set; }
        public string elec4_dline { get; set; }

        public string ethics_desc { get; set; }
        public string ethics_dline { get; set; }

        public string networks_desc { get; set; }
        public string networks_dline { get; set; }

        public string fieldtrips_desc { get; set; }
        public string fieldtrips_dline { get; set; }

        public string software_desc { get; set; }
        public string software_dline { get; set; }

        public string techno_desc { get; set; }
        public string techno_dline { get; set; }

        public string tqm_desc { get; set; }
        public string tqm_dline { get; set; }
    }
}
