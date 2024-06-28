using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {

          public class Rootobject
          {
              public string status { get; set; }
              public Data data { get; set; }
              public string message { get; set; }
          }

        public class Data
        {
            /*public int id { get; set; }
            public string employee_name { get; set; }
            public int employee_salary { get; set; }
            public int employee_age { get; set; }
            public string profile_image { get; set; }
*/


            public string student_no { get; set; }
            public string student_name { get; set; }
            public int degree_id { get; set; }
            public int specialization_id { get; set; }
            public string email { get; set; }
            public int faculty { get; set; }
            public int department_id { get; set; }
            public string image { get; set; }
            public int starting_yr { get; set; }

        }

    }
}
