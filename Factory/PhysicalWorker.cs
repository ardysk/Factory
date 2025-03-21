using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PhysicalWorker : Person
    {
        public PhysicalWorker(string name, string surname) : base(name, surname) { }

        public override int Cost(int months)
        {
            return 8000 * months; //pension multiplied by months count
        }
    }
}
