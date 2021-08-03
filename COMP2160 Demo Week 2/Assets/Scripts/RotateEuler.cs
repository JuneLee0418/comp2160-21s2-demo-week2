using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEuler : MonoBehaviour
{
    public bool rotateX = true;
    public bool rotateY = true;
    public bool rotateZ = true;

    void Update()
    {

        if (Input.GetButtonDown(InputAxes.Reset))
        {
            // reset to starting position
            transform.localRotation = Quaternion.identity;
        }

        float rx = rotateX ? Input.GetAxis(InputAxes.RotatePitch) : 0;        
        float ry = rotateY ? Input.GetAxis(InputAxes.RotateHeading) : 0;        
        float rz = rotateZ ? Input.GetAxis(InputAxes.RotateRoll) : 0;

        Vector3 eulerAngles = new Vector3(rx, ry, rz);
        transform.eulerAngles += eulerAngles;
    }
}
