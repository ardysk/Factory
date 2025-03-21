using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Robot
    {
        public String name { get; private set; }//auto field getter and setter
        public String type { get; private set; }
        public Robot(string name, string type) //parametric constructor 
        {
            this.type = type;
            this.name = name;
        }

        public abstract int AnnualCost(); //Annual cost of ever robot

        public override string ToString() //destription of robot
        {
            return $"Name: {name}";
        }
    }
}
