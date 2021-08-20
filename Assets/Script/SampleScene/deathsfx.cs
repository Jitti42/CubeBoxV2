using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathsfx : MonoBehaviour
{
    public AudioSource death;
    public GameObject d;

    void OnCollisionEnter2D(Collision2D D)
    {
        if(D.gameObject.tag=="box1")
        {
            d.SetActive(true);
            death.Play();
        }
        else if(D.gameObject.tag=="box2")
        {
            d.SetActive(true);
            death.Play();
        }
        else if(D.gameObject.tag=="BG")
        {
            d.SetActive(true);
            death.Play();
        }
    }
}
