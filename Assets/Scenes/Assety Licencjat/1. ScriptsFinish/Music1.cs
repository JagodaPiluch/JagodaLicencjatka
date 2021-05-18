using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : MonoBehaviour
{
    public AudioSource AA, BB, CC, DD, EE;


    public void PlayAA()
    {
        AA.Play();
        BB.Play();
        CC.Play();
        DD.Play();
        EE.Play();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BB")
        {
            BB.Play();
        }
        if (other.tag == "DD")
        {
            DD.Play();
        }
        if (other.tag == "PlayNarrator")
        {
            EE.Play();
        }
        if (other.tag == "StopNarrator")
        {
            EE.Stop();
        }



        /* public AudioClip AA, BB, CC, DD;
      public float Volume;
      AudioSource audio;
      public bool alreadyPlayer = false;


      private void Start()
      {
          audio.GetComponent<AudioSource>();
      }


      void OnTriggerEnter()
      {
          if (!alreadyPlayer)
          {
              audio.PlayOneShot(BB, Volume);
              alreadyPlayer = true;
          }*/

    }

}

