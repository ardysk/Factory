using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class MechanicalRobot : Robot
    {
        public MechanicalRobot(string name, string type) : base(name, type) { }//base constructor

        public override int AnnualCost()
        {
            return 60000; //Price for mechanical is higher couse u need to fix it more often i guess
        }
    }
}
