using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3v1
{
    class Institute
    {
        public DataTable institute = new DataTable("Institute");
        public DataColumn institute_id = new DataColumn("Institute_id");
        public DataColumn institute_name = new DataColumn("Institute_name");
        public DataColumn department_id = new DataColumn("Department_id");
    }
}
