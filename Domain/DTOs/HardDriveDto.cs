namespace Models
{
    public partial class HardDriveDto
    {
        public string StorageUnitDescription => StorageUnit.ToString();
        public string HardDriveTypeDescription => HardDriveType.ToString();
    }
}