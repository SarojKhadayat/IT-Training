using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public partial class Customer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNo { get; set; }
        public string Branch { get; set; }
        public bool HasLoan()
        {
            return true;
        }
    }

    public partial class Customer
    {
        public bool hasSMSBanking()
        {
            return false;
        }
        public bool hasEBanking()
        {
            return true;
        }
    }
}
