using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public Transform narrator;
    public Transform start;
    public Transform end;
    public float speed = 1F;
    private float time;
    [SerializeField] private float distCovered, fractionOfJourney;
    [SerializeField] private float journeyLength;
    [SerializeField] private bool startWalk;

    private void Start()
    {
        startWalk = false;
        journeyLength = Vector3.Distance(start.position, end.position);
    }
    private void Update()
    {
        if (startWalk == true)
        {
            time += Time.deltaTime;
            // time++;
            distCovered = time * speed; //(Time.time - startTime) * speed;
            fractionOfJourney = distCovered / journeyLength;

            transform.position = Vector3.Lerp(start.position, end.position, fractionOfJourney);

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Duszek"))

        {
            startWalk = true;

        }
    }

}
