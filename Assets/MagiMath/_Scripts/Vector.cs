using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaginaMath{
    public class Vector
    {


        public float x, y, z;
        public Vector(float x, float y, float z)
        {

            this.x = x;
            this.y = y;
            this.z = z;
        }


        public static Vector operator +(Vector a, Vector b)
        {
            var vec = new Vector(a.x + b.x, a.y + b.y, a.z + b.y);
            return vec;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            var vec = new Vector(a.x - b.x, a.y - b.y, a.z - b.y);
            return vec;
        }
    }
}