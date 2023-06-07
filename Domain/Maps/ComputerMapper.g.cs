using Models;

namespace Models
{
    public static partial class ComputerMapper
    {
        public static ComputerDto AdaptToDto(this Computer p1)
        {
            return p1 == null ? null : new ComputerDto()
            {
                Id = p1.Id,
                RamId = p1.RamId,
                GraphicsCardId = p1.GraphicsCardId,
                HardDriveId = p1.HardDriveId,
                Psu = p1.Psu,
                WeightQuantity = p1.WeightQuantity,
                WeightUnitId = p1.WeightUnitId,
                ProcessorId = p1.ProcessorId
            };
        }
        public static ComputerDto AdaptTo(this Computer p2, ComputerDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            ComputerDto result = p3 ?? new ComputerDto();
            
            result.Id = p2.Id;
            result.RamId = p2.RamId;
            result.GraphicsCardId = p2.GraphicsCardId;
            result.HardDriveId = p2.HardDriveId;
            result.Psu = p2.Psu;
            result.WeightQuantity = p2.WeightQuantity;
            result.WeightUnitId = p2.WeightUnitId;
            result.ProcessorId = p2.ProcessorId;
            return result;
            
        }
    }
}