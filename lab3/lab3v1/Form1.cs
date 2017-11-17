using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Institute institute = new Institute();
        Department department = new Department();
        Teacher teacher = new Teacher();

        void Parameters(DataTable table, DataColumn column, bool id, int size) //параметри таблиць
        {
            if (id)
            {
                column.DataType = typeof(int);
                column.Unique = true;
                column.AutoIncrement = true;
                column.AutoIncrementSeed = 0; //-1
                column.AutoIncrementStep = 1; //-1
                column.AllowDBNull = false;
                table.Columns.Add(column);
                table.PrimaryKey = new DataColumn[] { column };
                
            }
            else
            {
                column.MaxLength = size;
                column.AllowDBNull = false;
                table.Columns.Add(column);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Parameters(institute.institute, institute.institute_id, true, 6);
            Parameters(institute.institute, institute.institute_name, false, 30);
            Parameters(institute.institute, institute.department_id, false, 6);


            Parameters(department.department, department.department_id, true, 6);
            Parameters(department.department, department.department_name, false, 30);
            Parameters(department.department, department.teacher_id, false, 6);


            Parameters(teacher.teacher, teacher.teacher_id, true, 6);
            Parameters(teacher.teacher, teacher.teacher_name, false, 30);
            Parameters(teacher.teacher, teacher.teacher_surname, false, 30);
            Parameters(teacher.teacher, teacher.teacher_lastName, false, 30);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*DataSet relationships = new DataSet("Relationship");
            DataTable inst = relationships.Tables.Add("Institute");
            DataTable dep = relationships.Tables.Add("Department");
            DataTable teach = relationships.Tables.Add("Teacher");

            inst.Columns.Add("Institute_id", typeof(Guid));
            inst.Columns.Add("Institute_name", typeof(string));
            inst.Columns.Add("Department_id", typeof(Guid));
            inst.PrimaryKey = new DataColumn[] {inst.Columns["Institute_id"]};

            dep.Columns.Add("Department_id", typeof(Guid));
            dep.Columns.Add("Department_name", typeof(string));
            dep.Columns.Add("Teacher_id", typeof(Guid));
            dep.PrimaryKey = new DataColumn[] {dep.Columns["Department_id"]};

            teach.Columns.Add("Teacher_id", typeof(Guid));
            teach.Columns.Add("Teacher_name", typeof(string));
            teach.Columns.Add("Teacher_surename", typeof(string));
            teach.Columns.Add("Teacher_lastName", typeof(string));
            teach.PrimaryKey = new DataColumn[] {teach.Columns["Teacher_id"]};

            relationships.Relations.Add("Department_Institute",
                dep.Columns["Department_id"], inst.Columns["Department_id"]);
            relationships.Relations.Add("Teacher_Department",
                teach.Columns["Teacher_id"], dep.Columns["Teacher_id"]);

            DataRow teachRow = null;
            teachRow = teach.NewRow();
            Guid teachId = Guid.NewGuid();
            teachRow["Teacher_id"] = teachId;
            teachRow["Teacher_name"] = "Наталя";
            teachRow["Teacher_surename"] = "Михайлин";
            teachRow["Teacher_lastName"] = "Євгенівна";
            teach.Rows.Add(teachRow);

            teachRow = teach.NewRow();
            teachRow["Teacher_id"] = Guid.NewGuid();
            teachRow["Teacher_name"] = "Іра";
            teachRow["Teacher_surename"] = "Кандяк";
            teachRow["Teacher_lastName"] = "Василівна";
            teach.Rows.Add(teachRow);

            DataRow depRow = null;
            depRow = dep.NewRow();
            Guid depId = Guid.NewGuid();
            depRow["Department_id"] = depId;
            depRow["Department_name"] = "IKNI";
            depRow["Teacher_id"] = teachId;
            dep.Rows.Add(depRow);

            DataRow instRow = null;
            instRow = inst.NewRow();
            instRow["Institute_id"] = Guid.NewGuid();
            instRow["Institute_name"] = "НУ ЛП";
            instRow["Department_id"] = depId;
            inst.Rows.Add(instRow);

            ////////////////////////////
            textBox1.AppendText("\r\n ParentToChildren \r\n");
            DataRow[] child = teachRow.GetChildRows("Teacher_Department");

            foreach (DataRow dr in child)
            {
                textBox1.AppendText(
                    string.Format("Part :  {0}  \r\n", teachRow["Teacher_name"])
                );
            }
            textBox1.AppendText("/////////////");*/

            //create vendor dataset 
           
            
            /*DataSet vendorData = new DataSet("VendorData");
            DataTable vendors = vendorData.Tables.Add("Vendors");
            vendors.Columns.Add("Id", typeof(Guid));
            vendors.Columns.Add("Name", typeof(string));
            vendors.Columns.Add("Address1", typeof(string));
            vendors.Columns.Add("Address2", typeof(string));
            vendors.Columns.Add("City", typeof(string));
            vendors.Columns.Add("State", typeof(string));
            vendors.Columns.Add("ZipCode", typeof(string));
            vendors.Columns.Add("Country", typeof(string));
            vendors.PrimaryKey = new DataColumn[] { vendors.Columns["Id"] };
            DataTable parts = vendorData.Tables.Add("Parts");
            parts.Columns.Add("Id", typeof(Guid));
            parts.Columns.Add("VendorId", typeof(Guid));
            parts.Columns.Add("PartCode", typeof(string));
            parts.Columns.Add("PartDescription", typeof(string));
            parts.Columns.Add("Cost", typeof(decimal));
            parts.Columns.Add("RetailPrice", typeof(decimal));
            parts.PrimaryKey = new DataColumn[] { parts.Columns["Id"] };
            vendorData.Relations.Add("vendors_parts", vendors.Columns["Id"], parts.Columns["VendorId"]);
            DataTable vendorTable = vendorData.Tables["Vendors"];




            DataRow vendorRow = null;
            vendorRow = vendors.NewRow();
            Guid vendorId = Guid.NewGuid();
            vendorRow["Id"] = vendorId;
            vendorRow["Name"] = "Tailspin Toys";
            vendors.Rows.Add(vendorRow);
            DataRow partRow = null;
            partRow = parts.NewRow();
            partRow["Id"] = Guid.NewGuid();
            partRow["VendorId"] = vendorId;
            partRow["PartCode"] = "WGT1";
            partRow["PartDescription"] = "Widget 1 Description";
            partRow["Cost"] = 10.00;
            partRow["RetailPrice"] = 12.32;
            parts.Rows.Add(partRow);
            partRow = parts.NewRow();
            partRow["Id"] = Guid.NewGuid();
            partRow["VendorId"] = vendorId;
            partRow["PartCode"] = "WGT2";
            partRow["PartDescription"] = "Widget 2 Description";
            partRow["Cost"] = 9.00;
            partRow["RetailPrice"] = 11.32;
            parts.Rows.Add(partRow);
            //Navigate parent to children 
            textBox1.AppendText("\r\nParent to Children\r\n");
            DataRow[] childParts = vendorRow.GetChildRows("vendors_parts");
            foreach (DataRow dr in childParts)
            {
                textBox1.AppendText(
                string.Format("Part: {0} from {1}\r\n",
                dr["PartCode"], vendorRow["Name"]));
            }
            textBox1.AppendText("--------------------------------\r\n"); */
        }
    }
}
