using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisePrograms
{
    internal class datatableado_net
    {
        public void datatable()
        {
            try
            {
                //datatable class object
                DataTable employees = new DataTable("Employees");
                //adding column to Employees table

                //column 1
                DataColumn id=new DataColumn("id");
                id.Caption= "EmpId";
                id.AllowDBNull = false;//iska matlab isme null value nahi ho sakta hai
                id.DataType = typeof(int);
                //id.AutoIncrement = true;        // Enables auto-increment
                //id.AutoIncrementSeed = 1;       // Starting value (like identity seed)
                //id.AutoIncrementStep = 1;       // Increment step (like identity increment)
                //id.ReadOnly = true;             // Prevent editing
                //employees.PrimaryKey = new DataColumn[] { id };  //Making id pk
                employees.Columns.Add(id);

                //column 2
                DataColumn empname = new DataColumn("empname");
                empname.Caption = "EmpName";
                empname.AllowDBNull = false;
                empname.DataType = typeof(string);
                empname.MaxLength = 50;
                employees.Columns.Add(empname);

                //column 3
                DataColumn empgander = new DataColumn("empgander");
                empgander.Caption = "EmpGannder";
                empgander.AllowDBNull = false;
                empgander.DataType = typeof(string);
                empgander.MaxLength = 20;
                employees.Columns.Add(empgander);

                //Adding data in columns
                employees.Rows.Add(1,"Nitin","Male");
                employees.Rows.Add(2,"Ashish","Male");
                employees.Rows.Add(3,"Omkar","Male");
                employees.Rows.Add(4,"Indresh","Male");

                //Printing table Column
                foreach (DataColumn dc in employees.Columns)
                {
                    Console.Write(dc.ColumnName+" ");
                }
                //Printing table rows
                foreach (DataRow dr in employees.Rows)
                {
                    Console.WriteLine();
                    //For all rows
                    //Console.WriteLine("{0} {1} {2}",dr[0],dr[1],dr[2]);
                    //Console.WriteLine(dr[0]+" "+ dr[1]+" "+dr[2]);
                    //for specific rows
                    Console.Write("{0} {1}", dr["empname"], dr["empgander"]);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
