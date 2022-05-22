using System;

namespace LessonL3
{
    class ProgramL3
    {
        public void Main(string[] args)
        {

        }

        ///OCP
        //public double Permiter(Shape[] shapes)
        //{
        //    double perimeter = 0;
        //    foreach (var shape in shapes)
        //    {
        //        perimeter += shape.Perimeter();
        //    }
        //    return perimeter;
        //}
    }

    ///ISP - everything need to be as independent as it can get.

    //public class Animal
    //{
    //    public string Name { get; set; }
    //    public string Sex { get; set; }
    //    public string Type { get; set; }

    //    public void Breed()
    //    {

    //    }

    //}

    //public class Carasi : Animal, ICanSwim
    //{
    //    public string Name { get; set; }
    //    public string Sex { get; set; }
    //    public string Type { get; set; }

    //    public void Depth()
    //    {
    //        Name = Name + "a";
    //    }
    //}

    //public class Turtle : Animal, ICanSwim, ICanWalk
    //{
    //    public void Depth()
    //    {

    //    }
    //    public void Walk()
    //    {

    //    }
    //}

    //public class Human : Animal, IAmAHuman
    //{
    //    public void Walk()
    //    {

    //    }
    //    public void Depth()
    //    {

    //    }
    //}

    //public interface ICanFly
    //{
    //    public void Altitude();
    //}
    //public interface ICanSwim
    //{
    //    public void Depth();
    //}
    //public interface ICanWalk
    //{
    //    public void Walk();
    //}

    //public interface IAmAHuman : ICanWalk, ICanSwim
    //{

    //}

    //

    ///Lyskov - Daca ceva e ceva da nu poate face ceia ce poate ceva in general, trebuie de scos separat.

    //public class Fridge
    //{
    //    public double Tempreture { get; set; }
    //}

    //public class SmartFridge : Fridge
    //{
    //    public void MakeShoppingList()
    //    {

    //    }
    //}

    //public class SovietFridge : Fridge
    //{

    //}
    //public class GermanFridge : SmartFridge
    //{

    //}

    ///OCP - open for extension / closed for modification - define a method and just extend it for every sitaution you need.

    //public abstract class Shape
    //{
    //    public abstract double Perimeter();

    //}

    //public class Traingle : Shape
    //{
    //    public double l1 { get; set; }
    //    public double l2 { get; set; }
    //    public double l3 { get; set; }

    //    public override double Perimeter()
    //    {
    //        return l1 + l2 + l3;
    //    }
    //}

    //public class Square : Shape
    //{
    //    public double l { get; set; }
    //    public override double Perimeter()
    //    {
    //        return l * 4;
    //    }
    //}
}