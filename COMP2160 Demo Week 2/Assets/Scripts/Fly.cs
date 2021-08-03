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
        // using 'd' as 'delta' to indicate the variable is a change in position
        float dForward = Input.GetAxis(InputAxes.Forward);
        transform.Translate(dForward * speed * Vector3.forward * Time.deltaTime, Space.Self);

        // rotate
        // using 'd' as 'delta' to indicate the variable is a change in rotation
        float dRoll = Input.GetAxis(InputAxes.RotateRoll) * rotateSpeed * Time.deltaTime;
        float dPitch = Input.GetAxis(InputAxes.RotatePitch) * rotateSpeed * Time.deltaTime;
        float dHeading = Input.GetAxis(InputAxes.RotateHeading) * rotateSpeed * Time.deltaTime;

        // note this suffers from gimbal-lock when pitch >= 90 degress
        // https://en.wikipedia.org/wiki/Gimbal_lock
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(dPitch, dHeading, dRoll);
    }
}
