using System.Collections.Generic;
using System.Linq;
using Models;
using Models.Enums;

namespace Services
{
    public interface IUsbUpdaterService
    {
        void AddOrUpdateUpdateComputerUsbs(Computer computer, ComputerDto dto);
    }
    
    public class UsbUpdaterService : IUsbUpdaterService
    {
        public void AddOrUpdateUpdateComputerUsbs(Computer computer, ComputerDto dto)
        {
            UpdateComputerUsbAndDeleteIfZero(computer, EUsbType.USB2, dto.UsbCounts.Usb2);
            UpdateComputerUsbAndDeleteIfZero(computer, EUsbType.USB3, dto.UsbCounts.Usb3);
            UpdateComputerUsbAndDeleteIfZero(computer, EUsbType.USBC, dto.UsbCounts.UsbC);
        }
        
        private void UpdateComputerUsbAndDeleteIfZero(Computer computer, EUsbType usbType, short newCount)
        {
            UsbQuantity quantity = computer.Usbs?.SingleOrDefault(x => x.UsbType == usbType);
            if (quantity != null)
            {
                if (newCount == 0)
                {
                    computer.Usbs.Remove(quantity);
                }
                else
                {
                    quantity.Quantity = newCount;
                }
            }
            else if (newCount > 0)
            {
                computer.Usbs ??= new List<UsbQuantity>();
                computer.Usbs.Add(new UsbQuantity()
                {
                    UsbType = usbType,
                    Quantity = newCount,
                });
            }
        }
    }
}