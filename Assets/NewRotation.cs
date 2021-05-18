using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewRotation : MonoBehaviour
{
    /* public Transform Gracz;
     public float speed = 1f;


     Vector3 currentEulerAngles;
     Quaternion currentRotation;

     float rotationSpeed = 10;
     private Vector3 newDirection;
     public Transform Projekt;
     public float radius = 5f;
     public Transform target; 
     // /////////////////////////
     /// ///////////////////////

     float smooth = 5f;
     float tiltAngle = 60.0f;
     public Transform target; 

     public GameObject Gracz;
     public GameObject Swiat;
     public float speed;
     private Vector3 target = new Vector3(0f, 5f, 0f);
     public Transform targett;
     float smooth = 5f;
     void Start()
     {
       //  Vector3 pozycja1 = Gracz.position;
       //  Vector3 pozycja2;
       //  pozycja2 = pozycja1;

     }
     private float AngleTo(Vector3 position, Vector3 target)
     {

         position = targett.position - transform.position;
          =
     }



     private double angleBetweenExample()
     {
         Vector3 vector1 = new Vector3(0f, 1f, 0f);
         Vector3 vector2 = new Vector3(0f, 5f, 0f);
         double angleBetween;

         angleBetween = Vector3.AngleBetween(vector1, vector2);
         return angleBetween;

     }

     void Update()
     {
         function SignedAngle( Vector3 a, Vector3 b)

         {   
             var angle = Vector3.Angle(a, b); // calculate angle
                                              // assume the sign of the cross product's Y component:
             return angle * Mathf.Sign(Vector3.Cross(a, b).y);
         }


         function SignedAngle()
         {
             Vector3 a = Vector.zero;
             Vector3 b;

             var angle = Vector3.Angle(a, b); // calculate angle

             world.transform.RotateAround(player.transform.position, angle, 10 * Time.deltaTime);  // Ta funcja powoduje że CameraRig się obraca
             Vector3 globalnyYlokalnie;
             globalnyYlokalnie = transform.InverseTransformDirection(Vector3.up);                                 
         }


         private float AngleTo(Vector3 position, Vector3 target)
     {
         Vector3 diference = Vector3.zero;

         if (target.x > position.x)
             diference = target - position;
         else
             diference = position - target;

         return Vector3.Angle(Vector3.right, diference);
     }

     private float AngleTo(Vector3 position, Vector3 target)
     {
         Vector3 diference = Vector3.zero;

         if (target.x > position.x)
             diference = target - position;
         else
             diference = position - target;

         double angleBetween;
         angleBetween = Vector3.SignedAngle(Vector3.right, diference);
         return angleBetween;
     }

     //This returns the angle in degrees
     public static float AngleInDeg(Vector3 vec1, Vector3 vec2)
     {
         return AngleInRad(vec1, vec2) * 180 / Mathf.PI;

     }
    ____________________________________________________________

     public Transform Player;
     public Transform Target;

     Transform position1;
     Transform position2;

     void Start()
     {
         position1 = Target.transform;
         position2 = Target.transform;
     }

     void Update()
     {
         position1 = Target.transform;
         positionDiff = position2 - position1

     position2 = position1;

         if (positionDiff.x > 0)
         { // idziemy w prawo...
         }
         if (positionDiff.x < 0)
         { // idziemy w lewo...
         }

     }

     //pos1 = (1,0,1)
     //pos2 = (0.5,0,1)

     //diff.x = -0.5 (target idzie w lewą stronę)
    _________________________________________________________

     void Update()
     {


             Vector3 PointA = new Vector3(x, y, z);
             Vector3 PointB = new Vector3(x, y, z);
             float Angle = Vector3.Angle(PointA, PointB);  //If the angle isn't correctly at 0, you can subtract this value by the offset degree
             Debug.Log("Angle of PointA to PointB is " + Angle);


         // Vector3 targettDir = targett.position - transform.position;            // Zwraca kąt w stopniach między od a do. Zwrócony kąt to kąt bez znaku między dwoma wektorami.Oznacza to, że używany jest mniejszy z dwóch możliwych kątów między dwoma wektorami. Wynik nigdy nie jest większy niż 180 stopni.
         //float angle = Vector3.Angle(targettDir, transform.forward);

         // if (angle < 1.0f
         Swiat.transform.RotateAround(target, Vector3.up, -10 * Time.deltaTime * smooth);  // Ta funcja powoduje że CameraRig się obraca
             Vector3 globalnyYlokalnie;
             globalnyYlokalnie = transform.InverseTransformDirection(Vector3.up);
         //   Gracz.transform.rotation *= Quaternion.AngleAxis(speed, Vector3.up);


       */






    // target.transform.rotation = Quaternion.AngleAxis(30, Vector3.up);


    /* Vector3 targetDir = target.position - transform.position;
     float angle = Vector3.Angle(targetDir, transform.forward);

     if (angle < 5.0f)
         print("close");
     */
    //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);




    // Smoothly tilts a transform towards a target rotation.
    // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
    //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

    // Rotate the cube by converting the angles into a quaternion.
    // Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

    // Dampen towards the target rotation
    //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);


    //float perimeter = 2.0f * Mathf.PI * radius;
    //Debug.Log("The perimeter of the circle is: " + perimeter);



    // Vector3 GraczDirection = Gracz.position - transform.position;
    // float singleStep = speed * Time.deltaTime;
    //Vector3 newDirection = Vector3.RotateTowards(transform.right, GraczDirection, singleStep, 0.1f);
    // transform.rotation = Quaternion.LookRotation(newDirection); 
    //Projekt.transform.rotation *= Quaternion.AngleAxis(Mathf.PI * 2 * transform.localPosition.y, Vector3.up);
    //Projekt.transform.position += Vector3.right * Time.deltaTime;

    //float step = speed * multiply;
    //transform.position = Vector3.MoveTowards(transform.position, Gracz.position, step);

    // //Projekt.rotation *= Quaternion.AngleAxis(Vector3.left)

}
