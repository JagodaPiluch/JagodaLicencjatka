using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationR : MonoBehaviour
{
    public GameObject world;
    public Transform player;
    public float radius = 5f;
    public float speed = 1f;

    void Start()
    {
        
    }


    void Update() 
    {
        
        //    sprawdzić funkcje movetovards
        //    sprawdzic funkcje rotateTowards
        //    sprawdzić funkcje distance
        //    .................................................................
        /*
        Vector3 playerDir = player.position - transform.position;
        float angleBetween = Vector3.Angle(transform.right, playerDir);
        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.right, playerDir, angleBetween, 0.0f);
        world.transform.rotation = Quaternion.AngleAxis(angleBetween, Vector3.up);
        Vector3 globalnyYlokalnie;
        globalnyYlokalnie = transform.InverseTransformDirection(Vector3.up);
        */
        
        //.................................................................
            
            
            /*

        Vector3 playerDir = player.position - transform.position;
        float angleBetween = Vector3.Angle(transform.right, playerDir);
        world.transform.rotation = Quaternion.AngleAxis(angleBetween, -Vector3.up);


        if(player) 
        {
            float dist = Vector3.Distance(player.position, transform.position);
            world.transform.rotation = Quaternion.AngleAxis(dist, -Vector3.up);

            world.transform.RotateAround(player.position, Vector3.up, angleBetween);

            Vector3 globalnyYlokalnie;
            globalnyYlokalnie = transform.InverseTransformDirection(Vector3.up);

        }
        */
    }
}

