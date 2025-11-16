namespace GeoObjectsApp
{
    public class River : GeographicObject
    {
        public double FlowSpeed { get; set; }
        public double TotalLength { get; set; }

        public River(double coordinateX, double coordinateY, string name, string description, double flowSpeed, double totalLength)
            : base(coordinateX, coordinateY, name, description)
        {
            FlowSpeed = flowSpeed;
            TotalLength = totalLength;
        }

        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo}\nШвидкість течії: {FlowSpeed} см/с\nДовжина: {TotalLength} км";
        }
    }
}