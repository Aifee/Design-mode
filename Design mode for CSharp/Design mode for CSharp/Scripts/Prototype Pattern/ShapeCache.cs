using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Prototype_Pattern
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = null;
            if (shapeMap.TryGetValue(shapeId, out cachedShape))
            {
                return (Shape)cachedShape.Clone();
            }
            return null;
        }
        public static T getShape<T>(string shapeId) where T : Shape
        {
            Shape cachedShape = null;
            if (shapeMap.TryGetValue(shapeId, out cachedShape))
            {
                return cachedShape.Clone<T>();
            }
            return null;
        }

        // 对每种形状都运行数据库查询，并创建该形状
        // shapeMap.put(shapeKey, shape);
        // 例如，我们要添加三种形状
        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            Square square = new Square();
            square.setId("2");
            shapeMap.Add(square.getId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}