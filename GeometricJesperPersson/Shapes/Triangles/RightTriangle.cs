namespace GeometricJesperPersson.Shapes.Triangles
{
    public class RightTriangle : GeometricThing
    {
        private float Height { get; }
        private float Base { get; }
        private float Hypotenuse { get; }

        /// <summary>
        /// Set the triangle's sides to the same as the input when instancing the object.
        /// </summary>
        /// <param name="height">in meter of the triangle.</param>
        /// <param name="theBase">in meter of the triangle.</param>
        /// <param name="hypotenuse">in meter of the triangle.</param>
        public RightTriangle(float height, float theBase, float hypotenuse)
        {
            Height = height;
            Base = theBase;
            Hypotenuse = hypotenuse;
        }

        /// <summary>
        /// Calculate the area of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The area of the triangle. 0 if fails.</returns>
        public override float GetArea() => Base * Height / 2 < float.MaxValue && Base >= 0 && Height >= 0 ?
            Base * Height / 2 : default;

        /// <summary>
        /// Calculate the perimeter of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The perimeter of the triangle. 0 if fails.</returns>
        public override float GetPerimeter() => (Base + Height + Hypotenuse < float.MaxValue && Base >= 0 && Height >= 0) ?
            Base + Height + Hypotenuse : default;
    }
}