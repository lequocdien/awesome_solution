using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace DynamicInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtValues = new DataTable();
            dtValues.Columns.Add("FIRSTNAME", typeof(string));
            dtValues.Columns.Add("LASTNAME", typeof(string));
            dtValues.Columns.Add("AGE", typeof(short));
            dtValues.Rows.Add("Lê", "Diện", 24);
            dtValues.Rows.Add("Lê", "D", 20);

            IList<Student> lstResult = Activator.CreateInstance<List<Student>>();
            foreach (DataRow objRow in dtValues.Rows)
            {
                var objInstance = Activator.CreateInstance<Student>();
                foreach (PropertyInfo objPropertyInfo in objInstance.GetType().GetProperties())
                {
                    var objValue = objPropertyInfo.PropertyType == dtValues.Columns[objPropertyInfo.Name.ToUpper()].DataType ? objRow[objPropertyInfo.Name.ToUpper()] : null;
                    objPropertyInfo.SetValue(objInstance, objValue);
                }

                lstResult.Add(objInstance);
            }

            Console.WriteLine();
        }
    }

    public class Student
    {
        public string FirstName {
            get; set;
        }

        public string LastName {
            get; set;
        }

        public short Age {
            get; set;
        }
    }
}
