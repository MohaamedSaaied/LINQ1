using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public employee(int id,string name,double salary) 
        {
            this.id= id;
            this.name= name;    
            this.salary= salary;
        }
        public override string ToString()
        {
            return $"id: {id} name: {name} Salary: {salary}";
        }
    }
}
