using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3v1
{
    class Department
    {
        public DataTable department = new DataTable("Depertment");
        public DataColumn department_id = new DataColumn("Department_id");
        public DataColumn department_name = new DataColumn("Department_name");
        public DataColumn teacher_id = new DataColumn("Teacher_id");
    }
}
