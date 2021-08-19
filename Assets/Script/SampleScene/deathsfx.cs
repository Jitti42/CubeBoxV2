using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathsfx : MonoBehaviour
{
    public AudioSource death;
    public GameObject d;

    void OnTriggerEnter2D(Collider2D D)
    {
        if(D.gameObject.tag=="box")
        {
            d.SetActive(true);
            death.Play();
        }
    }
}
