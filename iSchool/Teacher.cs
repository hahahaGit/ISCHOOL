using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool
{
   public class Teacher
    {
       private string _name;

       public string Name
       {
           get { return _name; }
           set
           {
               CheckName(value); _name = value; }
       }

       private static void CheckName(string name)
       {
           if (String.IsNullOrWhiteSpace(name) || name.Length<3)
           {
               throw new ArgumentException("Value is Nullllllloooooooshittttt or less than 2");
           }
       }

       public int Salary { get; set; }

        public Teacher(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Salary: {1}", Name, Salary);
        }
    }
}
