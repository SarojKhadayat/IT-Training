using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class BaseClass
    {
        public virtual float Area(float a, float b)
        {
            return (a * b);
        }
    }
    public class Triangle:BaseClass
    {
        public override float Area(float a, float b)
        {
            //float test = 0.5;
            float val=(0.5f * a * b);
            return val;
        }
    }
    public class Square:BaseClass
    {
        public float Area(float a)
        {
            return (a * a);
        }
    }
}
