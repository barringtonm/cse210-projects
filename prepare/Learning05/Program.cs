using System;

class Program
{
    static void Main(string[] args) 
    {   //Notice   
        //
        //
        List<Shape> shapes = new List<Shape>();


        Square s1    = Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4,5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);

        foreach ( Shape s in shapes)
        {
           //
        //
            string color = s.GetColor();

        //
        //
            double area = s1.GetColor();


            Console.WriteLine($"The {color} shape has an area of {area}.");

        }

        

    }   
    
    
    
    

}


    
