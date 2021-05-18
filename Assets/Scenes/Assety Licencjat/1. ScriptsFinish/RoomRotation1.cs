using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRotation1 : MonoBehaviour
{
    public Transform cam;
    public float mltp;
    public GameObject room;
    Vector3 lastPos;
    private void Start()
    {
        lastPos = cam.position;
        enabled = false;
    }

    public void Update()
    {

        cam.transform.position = new Vector3(cam.transform.position.x, 0, cam.transform.position.z);

        Vector3 startPos = cam.position;

        var d = Vector3.Distance(cam.position, lastPos);

        transform.rotation *= Quaternion.AngleAxis(d * mltp, Vector3.up);

        transform.position += startPos - cam.position;

        lastPos = cam.position;
    }


  


}
