using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoomR : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        RoomRotation1 a = other.GetComponent<RoomRotation1>();
        if (a != null)
        {
            a.enabled = true;
        }
    }

}
