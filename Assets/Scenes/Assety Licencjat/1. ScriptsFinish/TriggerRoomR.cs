using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoomR : MonoBehaviour
{
    public RoomRotation1 Rotate;
    public Movement1 mov;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Duszek")
        {
            Rotate.enabled = true;
            mov.enabled = true;
        }
    }

}
