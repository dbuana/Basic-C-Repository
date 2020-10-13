// Goal: Create a shape class, where their attributes and parameters are defined, and create their area calculation as the highlight feature. 
using System;

class Shape {
    string name;
    int sideOne;
    int sideTwo;
    static void Main(string[] args) {
        Shape square = new Shape();
        square.name = "Square";
        square.sideOne = Console.ReadLine();
        square.sideTwo = Console.ReadLine();
        public void CalculatingArea() {
            int area = sideOne * sideTwo;
            Console.WriteLine(area);
        }
        public void CalculatingPerimeter() {
            int perimeter = 2*(sideOne+sideTwo);
            Console.WriteLine(perimeter);
        }

        Shape triangle = new Shape();
        triangle.name = "Triangle";
        triangle.sideOne = 3;
        triangle.sideTwo = 4;
        int sideThree;
        triangle.sideThree = 3;
        public void CalculatingArea() {
            int area = (square.sideOne+square.sideTwo) / 2;
            Console.WriteLine(area);
        } 
        public void CalculatingPerimeter() {
            int perimeter = (triangle.sideOne*triangle.sideTwo*triangle.sideThree);
            Console.WriteLine(perimeter);
        }
    }
}