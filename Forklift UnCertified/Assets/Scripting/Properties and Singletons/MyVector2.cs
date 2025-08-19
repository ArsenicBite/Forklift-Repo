using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector2 : MonoBehaviour
{

    public float x, y;
    public float nx, ny;

    private float _magnitude;
    private float _squareMagnitude;
    private float _xangle;
    private float _yangle;
    private float _pythagorean;




    public float Magnitude
    {
        get { _magnitude = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)); return _magnitude; }
        set { 
            float currentMag = Mathf.Sqrt(x * x + y * y);
            x = x / currentMag * value;
            y = y / currentMag * value;
            _magnitude = value; 
        }
    }

    public float SquareMagnitude
    {
        get { _squareMagnitude = Mathf.Pow(x, 2) + Mathf.Pow(y, 2); return _squareMagnitude; }
        set { _squareMagnitude = value; }
    }

    public float XAngle
    {
        get { _xangle = Mathf.Atan2(y, x) * Mathf.Rad2Deg; return _xangle; }
        set {_xangle = value; }
    }

    public float YAngle
    {
        get { _yangle = Mathf.Atan2(x, y) * Mathf.Rad2Deg; return _yangle; }
        set { _yangle = value; }
    }

    void Start()
    {
        Debug.Log("x: " + x);
        Debug.Log("y: " + y);
        Debug.Log("Magnitude: " + Magnitude);
        Debug.Log("Square Magnitude: " + SquareMagnitude);
        Debug.Log("X Angle: " + XAngle);
        Debug.Log("Y Angle: " + YAngle);

        Magnitude = 45f;
        Debug.Log(x);
        Debug.Log(y);
    }

}
