using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Space space = Space.World;

    void Update()
    {
        if (Input.GetButtonDown(InputAxes.Reset))
        {
            // reset to starting position
            transform.localRotation = Quaternion.identity;
        }

        float rx = Input.GetAxis(InputAxes.RotatePitch);        
        float ry = Input.GetAxis(InputAxes.RotateHeading);        
        float rz = Input.GetAxis(InputAxes.RotateRoll);

        Vector3 eulerAngles = new Vector3(rx, ry, rz);
        transform.Rotate(eulerAngles, space);        
    }
}
