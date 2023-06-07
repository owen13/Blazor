using System;
using Models.Enums;

namespace Models
{
    public class ComputerWithDescriptionsDto : ComputerDto
    {
        public string RamDescription { get; set; }
        public string GraphicsCardDescription { get; set; }
        public string HardDriveDescription { get; set; }
        public string WeightDescription => $"{WeightQuantity} {WeightUnitDescription}";
        public string WeightUnitDescription => Enum.ToObject(typeof(EWeightUnit) , (int) WeightUnitId).ToString();
        public string ProcessorDescription { get; set; }
    }
}