using System;

namespace GeometricJesperPersson.Shapes.Triangles
{
    public class EquilateralTriangle : GeometricThing
    {
        private float SideABC { get; }

        /// <summary>
        /// Set the triangle's sides to the same as the input when instancing the object.
        /// </summary>
        /// <param name="side">sieze in meter of the triangles sides.</param>
        public EquilateralTriangle(float side)
        {
            SideABC = side;
        }

        /// <summary>
        /// Calculate the perimeter of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The perimeter of the triangle. 0 if fails.</returns>
        public override float GetPerimeter() => SideABC * 3 < float.MaxValue && SideABC >= 0 ?
            SideABC * 3 : default;

        /// <summary>
        /// Calculate the area of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The area of the triangle. 0 if fails.</returns>
        public override float GetArea() => GetHeight() * SideABC / 2 < float.MaxValue && SideABC >= 0 ?
            GetHeight() * SideABC / 2 : default;

        // using pythagyras to calculate the height.
        private float GetHeight() => MathF.Sqrt(MathF.Pow(SideABC, 2) - MathF.Pow(SideABC / 2, 2));
    }
}