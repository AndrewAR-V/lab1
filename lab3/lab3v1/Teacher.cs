using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3v1
{
    class Teacher
    {
        public DataTable teacher = new DataTable("Teacher");
        public DataColumn teacher_id = new DataColumn("Teacher_id");
        public DataColumn teacher_name = new DataColumn("Teacher_name");
        public DataColumn teacher_surname = new DataColumn("Teacher_surname");
        public DataColumn teacher_lastName = new DataColumn("Teacher_lastName");
    }
}
