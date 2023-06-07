using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Mapster;
using Models.Enums;

namespace Models
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class Computer
    {
        public Computer()
        {
            Usbs = new List<UsbQuantity>(); 
        }
        
        public int Id { get; set; }
        
        public int RamId { get; set; }
        [AdaptIgnore]
        public Ram Ram { get; set; }
        
        public int GraphicsCardId { get; set; }
        [AdaptIgnore]
        public GraphicsCard GraphicsCard { get; set; }
        
        public int HardDriveId { get; set; }
        [AdaptIgnore]
        public HardDrive HardDrive { get; set; }
        
        [AdaptIgnore]
        public List<UsbQuantity> Usbs { get; set; }
        
        public short Psu { get; set; }
        
        [Column(TypeName = "decimal(5,2)")]
        public decimal WeightQuantity { get; set; }
        
        public int WeightUnitId { get; set; }
        [AdaptIgnore]
        public WeightUnit WeightUnit { get; set; }
        
        public int ProcessorId { get; set; }
        [AdaptIgnore]
        public Processor Processor { get; set; }
    }   
}