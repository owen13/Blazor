using System;
using Models.Enums;

namespace Models
{
    public class UsbQuantity
    {
        public int Id { get; set; }
        
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        
        public EUsbType UsbType { get; set; }
        public string UsbTypeDescription => Enum.ToObject(typeof(EUsbType) , (int) UsbType).ToString();
        public short Quantity { get; set; }
    }
}