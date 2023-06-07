namespace Models
{
    public partial class ComputerDto
    {
        public int Id { get; set; }
        public int RamId { get; set; }
        public int GraphicsCardId { get; set; }
        public int HardDriveId { get; set; }
        public short Psu { get; set; }
        public decimal WeightQuantity { get; set; }
        public int WeightUnitId { get; set; }
        public int ProcessorId { get; set; }
    }
}