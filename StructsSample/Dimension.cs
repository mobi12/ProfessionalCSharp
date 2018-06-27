using System;

namespace StructsSample
{
    public struct Dimensions
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public Dimensions(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public static Dimensions SetEmpty()
        {
            return new Dimensions(0, 0);
        }

        public double Diagonal => Math.Sqrt(Length * Length + Width * Width);

        public override string ToString()
        {
            return $"Length: {_length} Width: {_width}";
        }
    }
}