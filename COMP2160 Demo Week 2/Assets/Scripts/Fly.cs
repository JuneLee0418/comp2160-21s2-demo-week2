using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 30;        // m/s
    public float rotateSpeed = 60;    // deg/s

    void Start()
    {
        
    }

    void Update()
    {
        // move forward
        float forward = Input.GetAxis(InputAxes.Forward);
        transform.Translate(forward * speed * Vector3.forward * Time.deltaTime, Space.Self);

        // rotate
        float roll = Input.GetAxis(InputAxes.RotateRoll) * rotateSpeed * Time.deltaTime;
        float pitch = Input.GetAxis(InputAxes.RotatePitch) * rotateSpeed * Time.deltaTime;
        float heading = Input.GetAxis(InputAxes.RotateHeading) * rotateSpeed * Time.deltaTime;

        transform.localEulerAngles = transform.localEulerAngles + new Vector3(pitch, heading, roll);
    }
}
