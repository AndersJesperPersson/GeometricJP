using System;

namespace GeometricJesperPersson.Shapes.Triangles
{
    public class IsosclesTriangle : GeometricThing // likbent
    {
        private float Base { get; }
        private float SideAC { get; }

        /// <summary>
        /// Set the triangle's sides to the same as the input when instancing the object.
        /// </summary>
        /// <param name="theBase">sieze in meter of the triangles base.</param>
        /// <param name="sideAC">sieze in meter of the triangles two other sides.</param>
        public IsosclesTriangle(float theBase, float sideAC)
        {
            Base = theBase;
            SideAC = sideAC;
        }

        /// <summary>
        /// Calculate the perimeter of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The perimeter of the triangle. 0 if fails.</returns>
        public override float GetPerimeter() => (Base + (SideAC * 2) < float.MaxValue && Base >= 0 && SideAC >= 0) ?
            Base + (SideAC * 2) : default;

        /// <summary>
        /// Calculate the area of the triangle. Takes only numbers same or bigger then 0.
        /// </summary>
        /// <returns>The area of the triangle. 0 if fails.</returns>
        public override float GetArea() => GetHeight() * Base / 2 < float.MaxValue && Base >= 0 && SideAC >= 0 ?
            GetHeight() * Base / 2 : default;

        // using pythagyras to calculate the height.
        private float GetHeight() => MathF.Sqrt(MathF.Pow(SideAC, 2) - MathF.Pow(Base / 2, 2));
    }
}