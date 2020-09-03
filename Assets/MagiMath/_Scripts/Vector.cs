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
            var vec = new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
            return vec;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            var vec = new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
            return vec;
        }

        public static Vector Cross(Vector a, Vector b)
        {
            var cross = new Vector((a.y * b.z) - (a.z - b.z), (a.x * b.z) - (a.z * b.x), (a.x * b.y) - (a.y * b.x)) ;

            return cross;
        }

        public static float Dot(Vector a, Vector b)
        {
            var dot = (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
            return dot;
        }

        public override string ToString()
        {
            return "Vector : (" + x + "," + y + "," + z + ")";
        }
    }
}