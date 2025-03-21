using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Computer : Robot, IInternetConnection
    {
        public bool InternetConnection {get; private set;}
        public Computer(string name, string type, bool internetConnection) : base(name, type)
        {
            InternetConnection = internetConnection; //has Internet connection
        }
        public override int AnnualCost()
        {
            return 40000;
        }
    }
}
