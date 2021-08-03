using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 30;        // m/s
    public float rotationSpeed = 60;    // deg/s
    public Vector3 axis = Vector3.up;

    void Start()
    {
        
    }

    void Update()
    {
        // move forward
        float forward = Input.GetAxis(InputAxes.Forward);
        transform.Translate(forward * speed * Vector3.forward * Time.deltaTime, Space.Self);

        // rotate
        float roll = Input.GetAxis(InputAxes.RotateRoll);
        float pitch = Input.GetAxis(InputAxes.RotatePitch);
        float heading = Input.GetAxis(InputAxes.RotateHeading);

        Quaternion qRoll = Quaternion.AngleAxis(roll, Vector3.forward);
        Quaternion qPitch = Quaternion.AngleAxis(pitch, Vector3.right);
        Quaternion qHeading = Quaternion.AngleAxis(heading, Vector3.up);

        Quaternion q = qHeading * qPitch * qRoll;
        transform.rotation = q * transform.rotation; 

    }
}
