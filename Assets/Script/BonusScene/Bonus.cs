using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bonus : MonoBehaviour
{
    

    private Animator animator;
    private Rigidbody2D rigidbody2D;

    private AudioSource audioSource;
    public AudioClip coin;

    

    

    public float speed;
    public float left;

    public UIManager uiManager;


    
    void Start()
    {

        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        uiManager.start();
    }


    void OnTriggerEnter2D(Collider2D c)
    {

        audioSource.PlayOneShot(coin);

        uiManager.plusScore();

    }

   



    



    
    
}
