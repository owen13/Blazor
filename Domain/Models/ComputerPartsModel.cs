using System.Collections.Generic;
using System.Linq;
using Models.Enums;
using Utilities;

namespace Models
{
    public class ComputerPartsModel
    {
        public KeyValuePair<int, string>[] Rams { get; set; }
        public KeyValuePair<int, string>[] GraphicsCards { get; set; }
        public KeyValuePair<int, string>[] HardDrives { get; set; }
        public KeyValuePair<int,string>[] UsbTypes => EnumConversion.EnumToArray<EUsbType>();

        public KeyValuePair<int, string>[] UsbsOfEachType =>
            Enumerable.Range(0, 10).Select(x => new KeyValuePair<int, string>(x, x.ToString())).ToArray();
        public KeyValuePair<int,string>[] WeightUnits => EnumConversion.EnumToArray<EWeightUnit>();
        public KeyValuePair<int, string>[] Processors { get; set; }
    }
}