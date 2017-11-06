using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_mode_for_CSharp.Scripts.Factory_Pattern;

public class ShapeFactoryDemo
{
    public ShapeFactoryDemo()
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        //获取 Circle 的对象，并调用它的 draw 方法
        //Shape shape1 = shapeFactory.GetShape("CIRCLE");
        //Shape shape1 = shapeFactory.GetShape(typeof(Circle));
        Shape shape1 = shapeFactory.GetShape<Circle>();

        //调用 Circle 的 draw 方法
        shape1.draw();

        //获取 Rectangle 的对象，并调用它的 draw 方法
        //Shape shape2 = shapeFactory.GetShape("RECTANGLE");
        //Shape shape2 = shapeFactory.GetShape(typeof(Rectangle));
        Shape shape2 = shapeFactory.GetShape<Rectangle>();

        //调用 Rectangle 的 draw 方法
        shape2.draw();

        //获取 Square 的对象，并调用它的 draw 方法
        //Shape shape3 = shapeFactory.GetShape("SQUARE");
        //Shape shape3 = shapeFactory.GetShape(typeof(Square));
        Shape shape3 = shapeFactory.GetShape<Square>();

        //调用 Square 的 draw 方法
        shape3.draw();


    }
}