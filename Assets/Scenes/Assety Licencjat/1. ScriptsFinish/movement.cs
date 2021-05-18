using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{  /*
    public Transform narrator;
    public Transform start;
    public Transform end;
    public float speed = 1.0F;
    private float startTime;

    private float journeyLength;
    private bool startWalk = false;

    private void Start()
    {
        startTime = Time.deltaTime;
        journeyLength = Vector3.Distance(start.position, end.position);
    }
    private void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;

        if (startWalk)
        {
            narrator.transform.position = Vector3.Lerp(start.position, end.position, fractionOfJourney);
        }

    }
    private void OnTriggerEnter(Collider other)
    {


            if (other.gameObject.CompareTag("Duszek"))

            {
                StartWalk();
            }
    }

    public void StartWalk()
    {
        startWalk = true;
    }
    */
}
