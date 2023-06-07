using Mapster;
using Models.Enums;

namespace Models
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class HardDrive
    {
        public int Id { get; set; }
        public short Size { get; set; }
        public EStorageUnit StorageUnit { get; set; }
        public EHardDriveType HardDriveType { get; set; }
    }
}