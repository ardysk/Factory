using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class OfficeWorker : Person, IInternetConnection
    {
        public bool InternetConnection { get; private set; }
        public OfficeWorker(string name, string surname, bool InternetConnection) : base(name, surname) 
        {
            this.InternetConnection = InternetConnection;
        }

        public override int Cost(int months)
        {
            return 9000 * months + 400;//pension plus yearly bonus for candy 
        }
    }
}
