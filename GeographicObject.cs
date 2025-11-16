namespace GeoObjectsApp
{
    public abstract class GeographicObject
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GeographicObject(double coordinateX, double coordinateY, string name, string description)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Name = name;
            Description = description;
        }

        public virtual string GetInfo()
        {
            return $"Назва: {Name}\nОпис: {Description}\nКоординати: ({CoordinateX}, {CoordinateY})";
        }
    }
}