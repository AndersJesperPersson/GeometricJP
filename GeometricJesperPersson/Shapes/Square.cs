
namespace GeometricJesperPersson.Shapes
{
    using System;
    public class Square : GeometricThing
    {
        private float A { get; }

        /// <summary>
        /// Set the square's side to the same as the input when instancing the object.
        /// </summary>
        /// <param name="side">size of the square´s sides´ in meter</param>
        public Square(float side)
        {
            A = side;
        }

        /// <summary>
        /// Calculate the area of the square. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The area in float. 0 if fails.</returns>
        public override float GetArea() => MathF.Pow(A, 2) < float.MaxValue && A >= 0 ? MathF.Pow(A, 2) : default;

        /// <summary>
        /// Calculate the perimeter of the square. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The perimeter in float. 0 if fails.</returns>
        public override float GetPerimeter() => A * 4 < float.MaxValue && A >= 0 ? A * 4 : default;
    }
}