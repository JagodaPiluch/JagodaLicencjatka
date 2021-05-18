using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    /*
    public Transform notes;
    public Material[] material;
    Renderer rend;

    AudioClip[] clips;
    AudioSource source;

    public Transform startPoint;
    public Transform endPoint;
    public GameObject Sluz;

    public float speed = 1f;
    private float startTime;
    private float journeyLength;


    void Start()
    {
        notes = Resources.LoadAll<ParticleSystem>("Particle//");         //renderowanie partikli
       // notes.GetComponent<ParticleSystem>().enableEmission = false;
        ParticleSystem notes = GetComponent<ParticleSystem>();
        var emiss = notes.emission;
        emiss.enabled = false;
        

        material = Resources.LoadAll<Material>("Materials//");            //renderowanie materiału
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        clips = Resources.LoadAll<AudioClip>("Pieces//");                 //puszczanie muzyki
        source = GetComponent<AudioSource>();

        startTime = startTime.time;                                       //czas i obliczenie dystansu między punktami
        journeyLength = Vector3.Distance(startPoint.position, endPoint.position);   
    }

    public void OnTriggerEnter(Collider button, int i)
    {
        if (button.gameObject.CompareTag("StartMusic"))
        {
            source.clip = clips[i];
            source.Play(0);
        }
            
    }

    void OnCollisionEnter(Collision collision, int i)
    {
      
        if (collision.gameObject.tag == "CorrectBox")
        {
            
            rend.sharedMaterial = material[1];                             //  green
            notes.GetComponent<ParticleSystem>().enableEmission = true;    // puszczane fajerwerki
            Invoke("NextLevel", 3f);
        }

        if (collision.gameObject.tag == "NotCorrectBox")
        {
            rend.sharedMaterial = material[2];                              //red
            Invoke("RenderingBlue", 0.5f);
        }

        if (collision.gameObject.tag == "StopMusic")
        {
            source.Pause();
        }
    }

    private void RenderingBlue()
    {
        rend.sharedMaterial = material[0];                                 //blue
    }

    private void NextLevel(Collision con)
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;
        Sluz.position = Vector3.Lerp(startPoint.position, endPoint.position, fractionOfJourney);   //otwieranie śluzy
        Vector3 end = Sluz.position;
        invoke("DownSluz");

      
       foreach(Transform child in transform)
        {
            if(coss)
            {
                                                           //opuszczenie się przedmiotów 
            }
        }


        if (end)
        {
            Sluz.localPosition = Vector3.Lerp(endPoint.position, startPoint.position, fractionOfJourney);   // zamykanie śluzy

        }

    }
 
    */
}
