using Models.Enums;

namespace Models
{
    public partial class HardDriveDto
    {
        public int Id { get; set; }
        public short Size { get; set; }
        public EStorageUnit StorageUnit { get; set; }
        public EHardDriveType HardDriveType { get; set; }
    }
}