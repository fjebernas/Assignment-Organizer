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
}
