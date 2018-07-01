using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.AdminPanel.UI.ReportingModule.MapObjects
{
    public class EmployeeDetails
    {
        public string emp_ID { get; set; }
        public string emp_Fname { get; set; }
        public string emp_Lname { get; set; }
        public object fix_ContactNo { get; set; }
        public object mobileNo { get; set; }
        public string Nic { get; set; }
        public string Designation { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string empAddress { get; set; }
        public double basicSalry { get; set; }
        public string regDate { get; set; }


    }
}
