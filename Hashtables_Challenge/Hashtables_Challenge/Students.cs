using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables_Challenge
{
    class Students
    {
        //Setup the class properties
        // ID
        public int ID { get; set; }
        //Name
        public string Name { get; set; }
        //GPA
        public float GPA { get; set; }

        //simple constructor
        public Students(int id,string name, float gpa)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
        }       
    }
}
