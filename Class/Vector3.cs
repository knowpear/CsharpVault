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
        //get方法, 提供訪問入口
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }

        public float getZ()
        {
            return z;
        }
        public void SetX(float temp)
        {
            if (temp < 0)
            {
                return; //代碼終止, 保持原來的值, 不會成為負的值
            }
            x = temp;
        }
        //set方法, 提供修改入口
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
        
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

    }
}
