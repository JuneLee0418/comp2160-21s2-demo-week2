using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 30;

    void Start()
    {
        
    }

    void Update()
    {
        float fwd = Input.GetAxis(InputAxes.Forward);
        transform.Translate(fwd * speed * Vector3.forward * Time.deltaTime, Space.Self);
    }
}
