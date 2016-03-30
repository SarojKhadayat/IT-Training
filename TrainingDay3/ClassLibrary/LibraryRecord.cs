using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryRecord:Basic
    {
        public DateTime BookTakenOn { get; set; }
        public long DueAmount { get; set; }
        public override string test { get; set; }
        
    }
}
