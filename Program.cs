using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PractisePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string cs = ConfigurationManager.ConnectionStrings
            // ["my_connection"].ConnectionString;

            //Two Matrix addition
            List<EmployeeModel> empList = new List<EmployeeModel>();
            EmployeeModel empModel= new EmployeeModel();
            empModel.Id = 1;
            empModel.Name = "Nitin";
            empModel.Age = 23;
            empList.Add(empModel);

            DataTable dt=new DataTable();
            dt.Columns.Add("Id",typeof(int));
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Age",typeof(int));
            foreach (var item in empList)
            {
                dt.Rows.Add(item.Id,item.Name,item.Age);
            }
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[0] +" "+ dr[1] +" "+ dr[2]);
            }

            Console.ReadKey();
        }

    }
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    
}





