using AkbankJumpp.OOPConsole.Common;
using AkbankJumpp.OOPConsole.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankJumpp.OOPConsole.Entities
{
    public class AccesControlLog : EntityBase<Guid>
    {
        public long PersonId { get; set; }
        public string DeviceSerialNo { get; set; }
        public AccesType accesType { get; set; }
        public DateTime LogTime { get; set; }

        public static AccesType ConvertStringToAccesType(string accesType)
        {
            switch (accesType)
            {
                case "FP":
                    return AccesType.FingerPrint;

                case "FACE":
                    return AccesType.Face;

                case "CARD":
                    return AccesType.Card;

                default:
                    throw new Exception("yanlış ödeme türü");

            }
        }
    }

}
