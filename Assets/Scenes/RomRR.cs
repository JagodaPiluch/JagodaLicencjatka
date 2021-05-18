using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomRR : MonoBehaviour
{
    public Transform cam;
    public float mltp;

    Vector3 lastPos;

    private void Start()
    {
        lastPos = cam.position;

    }
    
    void Update()
    {

        

        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.position += Vector3.forward * 0.2f;
        }
      /*  Vector3 startPos = cam.position;

        var d = Vector3.Distance(cam.position, lastPos);

        transform.rotation *= Quaternion.AngleAxis(d * mltp, Vector3.up);

        transform.position += startPos - cam.position;

        lastPos = cam.position;
      */
    }


}
