using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Vector3
    {//基本类型 0   值类型的默认值0   引用类型的默认值是null
        private float x;
        private float y;
        private float z;

        public void SetX(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            x = temp;
        }
        public void SetY(float temp)
        {
            if (temp < 0) return;
            y = temp;
        }
        public void SetZ(float temp)
        {
            if (temp < 0) return;
            z = temp;
        }
        public float getX()
        {
            return x;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

    }
}
