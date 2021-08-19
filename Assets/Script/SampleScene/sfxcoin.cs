using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxcoin : MonoBehaviour
{
    public AudioSource coinsfx;
    public GameObject co;
    void OnTriggerEnter2D(Collider2D ccc)
    {
        if(ccc.gameObject.tag == "coin")
        {
            co.SetActive(true);
            coinsfx.Play();
        }
    }
}
