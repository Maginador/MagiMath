using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MaginaMath;

public class MathDebug : MonoBehaviour
{

    public Vector3 testA, testB;
    // Start is called before the first frame update
    void Start()
    {
        var vec = new Vector(testA.x, testA.y, testA.z);
        var vec2 = new Vector(testB.x, testB.y, testB.z);
        Debug.Log("Vector 01 : " + vec.ToString());
        Debug.Log("Vector 02 : " + vec2.ToString());
        Debug.Log("Vector Add : " + (vec + vec2));
        Debug.Log("Vector Subtract : " + (vec - vec2));
        Debug.Log("Vector Dot : " + (Vector.Dot(vec,vec2)));
        Debug.Log("Vector Cross : " + (Vector.Cross(vec, vec2)));




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
