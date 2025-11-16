namespace GeoObjectsApp
{
    public class Mountain : GeographicObject
    {
        public double HighestPoint { get; set; }

        public Mountain(double coordinateX, double coordinateY, string name, string description, double highestPoint)
            : base(coordinateX, coordinateY, name, description)
        {
            HighestPoint = highestPoint;
        }

        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo}\nНайвища точка: {HighestPoint} м";
        }
    }
}