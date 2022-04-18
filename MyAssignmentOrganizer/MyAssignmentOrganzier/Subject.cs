using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssignmentOrganzier
{
    public class Subject
    {
        public static string Mode { get; set; } // static string for which subject to operate

        #region Fields
        private string _description = "";
        private string _deadline = "";
        #endregion
        #region Properties
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        #endregion
    }

    public class All
    {
        #region elec3
        public string elec3_desc { get; set; }
        public string elec3_dline { get; set; }
        #endregion
        #region elec4
        public string elec4_desc { get; set; }
        public string elec4_dline { get; set; }
        #endregion
        #region ethics
        public string ethics_desc { get; set; }
        public string ethics_dline { get; set; }
        #endregion
        #region networks
        public string networks_desc { get; set; }
        public string networks_dline { get; set; }
        #endregion
        #region fieldtrips
        public string fieldtrips_desc { get; set; }
        public string fieldtrips_dline { get; set; }
        #endregion
        #region software
        public string software_desc { get; set; }
        public string software_dline { get; set; }
        #endregion
        #region techno
        public string techno_desc { get; set; }
        public string techno_dline { get; set; }
        #endregion
        #region tqm
        public string tqm_desc { get; set; }
        public string tqm_dline { get; set; }
        #endregion
    }
}
