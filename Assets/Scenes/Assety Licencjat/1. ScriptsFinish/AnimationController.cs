using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anima;
    private bool startAnimation = false;
    void Start()
    {
        anima = GetComponent<Animator>();
    }
    public void StartAnimate()
    {
        startAnimation = true;
    }
    
    void Update()
    {
        if (startAnimation)
        {
            anima.Play("Duszek");
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Anima")

            if (other.gameObject.CompareTag("Anima"))

            {
                StartAnimate();
            }
    }
    
}
