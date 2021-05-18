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

    }

    public void Update()
    {

        cam.transform.position = new Vector3(cam.transform.position.x, 0, cam.transform.position.z);


        Vector3 startPos = cam.position;
        transform.position += startPos - cam.position;
        lastPos = cam.position;


    }


    void OnTriggerStay()
    {
        var d = Vector3.Distance(cam.position, lastPos);

        room.transform.rotation *= Quaternion.AngleAxis(d * mltp, Vector3.up);
    }


}
