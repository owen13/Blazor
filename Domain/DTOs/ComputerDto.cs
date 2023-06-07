using System;
using Mapster.Utils;
using Models.Enums;

namespace Models
{
    public partial class ComputerDto
    {
        public ComputerDto()
        {
            UsbCounts = new UsbCounts();
        }
        
        public UsbCounts UsbCounts { get; set; }
    }

    public class UsbCounts
    {
        public short Usb2 { get; set; }
        public short Usb3 { get; set; }
        public short UsbC { get; set; }
    }
}