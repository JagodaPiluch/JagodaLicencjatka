using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Transform Head;
    public float angle;
    Vector3 lastPos;
    private void Start()
    {
        lastPos = Head.position;
    }
    private void Update()
    {
        Head.transform.position = new Vector3(Camera.main.transform.position.x, 0, Camera.main.transform.position.z);
        Vector3 startPos = Head.position;

        float c = (Head.position - lastPos).magnitude;
        Head.localRotation = Quaternion.AngleAxis(c * angle, -Vector3.back);

        transform.position += startPos - Head.position;
        lastPos = Head.position;
    }
}
