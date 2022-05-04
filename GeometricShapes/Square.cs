using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal class Square {

        public int side1 { get; set; } = 0;

        public int Perimeter() {
            return side1 * 4;
        }
        public int area() {
            return side1 * side1;
        }
    }
}
