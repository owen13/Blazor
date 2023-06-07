using Models;

namespace Models
{
    public static partial class HardDriveMapper
    {
        public static HardDriveDto AdaptToDto(this HardDrive p1)
        {
            return p1 == null ? null : new HardDriveDto()
            {
                Id = p1.Id,
                Size = p1.Size,
                StorageUnit = p1.StorageUnit,
                HardDriveType = p1.HardDriveType
            };
        }
        public static HardDriveDto AdaptTo(this HardDrive p2, HardDriveDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            HardDriveDto result = p3 ?? new HardDriveDto();
            
            result.Id = p2.Id;
            result.Size = p2.Size;
            result.StorageUnit = p2.StorageUnit;
            result.HardDriveType = p2.HardDriveType;
            return result;
            
        }
    }
}