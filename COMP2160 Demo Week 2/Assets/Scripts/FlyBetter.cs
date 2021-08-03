using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Version of Fly script without gimbal lock
//
public class FlyBetter : MonoBehaviour
{
    public float speed = 30;        // m/s
    public float rotateSpeed = 60;    // deg/s

    private Vector3 eulerAngles;

    void Start()
    {
        eulerAngles = transform.localEulerAngles;    
    }

    void Update()
    {
        // move forward
        float dForward = Input.GetAxis(InputAxes.Forward);
        transform.Translate(dForward * speed * Vector3.forward * Time.deltaTime, Space.Self);

        // rotate
        float dRoll = Input.GetAxis(InputAxes.RotateRoll) * rotateSpeed * Time.deltaTime;
        float dPitch = Input.GetAxis(InputAxes.RotatePitch) * rotateSpeed * Time.deltaTime;
        float dHeading = Input.GetAxis(InputAxes.RotateHeading) * rotateSpeed * Time.deltaTime;

        // this avoids gimbal lock
        eulerAngles += new Vector3(dPitch, dHeading, dRoll);
        transform.localRotation = Quaternion.identity;
        transform.Rotate(eulerAngles);
    }
}
