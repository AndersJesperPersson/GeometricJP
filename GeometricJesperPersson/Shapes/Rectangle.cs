namespace GeometricJesperPersson.Shapes
{
    public class Rectangle : GeometricThing
    {
        private float A { get; }
        private float B { get; }

        /// <summary>
        /// Set the rectangle's sides to the same as the input when instancing the object.
        /// </summary>
        /// <param name="side1">height in meter.</param>
        /// <param name="side2">bottom in meter.</param>
        public Rectangle(float side1, float side2)
        {
            A = side1;
            B = side2;
        }

        /// <summary>
        /// Calculate the area of the rectangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The area in a float. 0 if fails.</returns>
        public override float GetArea() => (A * B < float.MaxValue && A >= 0 && B >= 0) ? A * B : default;

        /// <summary>
        /// Calculate the perimeter of the rectangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The perimeter in float. 0 if fails.</returns>
        public override float GetPerimeter() => (B >= 0 && A >= 0 && (A * 2) + (B * 2) < float.MaxValue) ?
            (A * 2) + (B * 2) : default;
    }
}