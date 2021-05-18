using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put1 : MonoBehaviour
{

    AudioClip[] clips;
    AudioSource source;
  
   private void Start()
    {
       clips = Resources.LoadAll<AudioClip>("Utwory//");      //Dwa razy slesz /n - to jest enter 
       source = GetComponent<AudioSource>();  
    }


    public void Play(int i)
    {
       source.clip = clips[i];
       source.Play();
    }
    

    /* void OnTriggerEnter(Collider basse)
      {
          
          if ( basse.gameObject.CompareTag("piano"))
          {
              source.clip = clips[i];
              source.Play();

          }

      }
    */
}
