using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal class Rect {

        public int Side1 { get; set; } = 0;
        public int Side2 { get; set; } = 0;

        public int Perimeter() {
            return 2 * (Side1 + Side2);
        }
        public int area() {
            return Side1 * Side2;
        }
    }
}
