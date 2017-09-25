namespace Lecture03
{
    using System;

    public class Box
    {       

        public Box(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public int Width { get; set; }

        public int Length { get; set; }

        public int Square
        {
            get
            {
                return Width * Length;
            }            
        }

        public static Box operator+(Box firstBox, Box secondBox)
        {
            if(firstBox != null && secondBox != null)
            {
                return new Box(firstBox.Width + secondBox.Width, firstBox.Length + secondBox.Length);
            }

            throw new Exception($"One of provided boxes are null. First box properties : {firstBox.ToString()}, second box properties : {secondBox.ToString()}");            
        }

        public override string ToString()
        {            
            return $"This instance of box is {Width} x {Length}, and square is {Square}";
        }
    }
}
