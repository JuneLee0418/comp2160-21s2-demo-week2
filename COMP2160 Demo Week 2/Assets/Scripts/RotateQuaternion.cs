using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateQuaternion : MonoBehaviour
{
    public Transform axisTransform;
    public Vector3 axis = Vector3.up;
    public float speed = 60; // deg / s

    void Update()
    {
        // rotate the axis object to point along the axis
        axisTransform.localRotation = Quaternion.FromToRotation(Vector3.up, axis);        

        // rotate the sphere around the axis
        float angle = Input.GetAxis(InputAxes.RotateHeading) * speed * Time.deltaTime;        
        Quaternion q = Quaternion.AngleAxis(angle, axis);

        transform.localRotation = q * transform.localRotation; 
    }
}
