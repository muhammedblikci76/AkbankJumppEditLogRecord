using AkbankJumpp.OOPConsole.Common;
using AkbankJumpp.OOPConsole.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankJumpp.OOPConsole.Entities
{
    public class Student : PersonBase
    {
    
        public int No { get; set; }

        public DateTimeOffset RegistirationDate { get; set; }

    }
}
  