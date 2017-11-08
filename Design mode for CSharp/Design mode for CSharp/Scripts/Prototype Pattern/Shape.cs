using System;
using System.Reflection;

namespace Design_mode_for_CSharp.Scripts.Prototype_Pattern
{
    [Serializable]
    public abstract class Shape : object, ICloneable
    {
        private string id;
        protected string type;

        public abstract void draw();

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            using (System.IO.Stream objectSteam = new System.IO.MemoryStream())
            {
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(objectSteam, this);
                objectSteam.Seek(0, System.IO.SeekOrigin.Begin);
                return formatter.Deserialize(objectSteam);
            }
        }
        public T Clone<T>() where T : Shape
        {
            using (System.IO.Stream objectSteam = new System.IO.MemoryStream())
            {
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(objectSteam, this);
                objectSteam.Seek(0, System.IO.SeekOrigin.Begin);
                return formatter.Deserialize(objectSteam) as T;
            }
        }

    }
}