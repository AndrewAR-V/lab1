using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
       

       static void Parameters(DataTable table ,DataColumn column, bool id,int size)//параметри таблиць
        {
            if (id)
            {
                table.PrimaryKey = new DataColumn[] { column };
                column.DataType = typeof(int);
                column.Unique = true;
                column.AutoIncrement = true;
                column.AutoIncrementSeed = 0;//-1
                column.AutoIncrementStep = 1;//-1
            }
           
           column.MaxLength = size;
           column.AllowDBNull = false;
            table.Columns.Add(column);
        }
        static void Main(string[] args)
        {
           
            Institute institute = new Institute();
            Parameters(institute.institute,institute.institute_id, true, 6);
            Parameters(institute.institute,institute.institute_name, false, 30);
            Parameters(institute.institute, institute.department_id, false, 6);

            Department department = new Department();
            Parameters(department.department, department.department_id, true, 6);
            Parameters(department.department, department.department_name, false, 30);
            Parameters(department.department, department.teacher_id, false, 6);

            Teacher teacher = new Teacher();
            Parameters(teacher.teacher,teacher.teacher_id, true, 6);
            Parameters(teacher.teacher, teacher.teacher_name, false, 30);
            Parameters(teacher.teacher, teacher.teacher_surname, false, 30);
            Parameters(teacher.teacher, teacher.teacher_lastName, false, 30);


        }
    }
}
