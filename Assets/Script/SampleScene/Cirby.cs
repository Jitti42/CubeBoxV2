using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Audio;



public class Cirby : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    
    public Vector2 velocity;
    public UIManager uiManager;
    private bool died;
    
   
    
    
    
    AudioSource _audio;
    public AudioMixerGroup _mixerGroupMicrophone, _mixerGroupMaster;
    public float sentivity = 100;
    public float loudness = 0;
    
    void Start()
    {
        
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D> ();
        
        uiManager.start();
        _audio = GetComponent<AudioSource>();
        _audio.outputAudioMixerGroup = _mixerGroupMicrophone;
        _audio.clip = Microphone.Start(null, true, 10, 44100);
        _audio.loop = true;
        _audio.mute = false;
        while (!(Microphone.GetPosition(null) > 0))
        {

            

        }
        _audio.Play();
        
        died = false; 
    }

    public void OnTriggerEnter2D (Collider2D c)
    {
        if (died)
            return;
        
        _audio.mute = false;
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, 2);
        uiManager.IncreaseScore();
        
    }

    void Update()
    {

           
        loudness = GetAveragedVolume() * sentivity;
        if(loudness > 1 )
        {
            
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, 2);
            animator.SetTrigger("IsFlap");
        }
       

        
    }

    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        _audio.GetOutputData(data, 0);
        foreach(float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256;
    }

    public void OnCollisionEnter2D (Collision2D c)
    {
        died = true;
       
        
        Invoke ("Ondied", 0);
        
    }

    void Ondied()
    {
       
        uiManager.ShowResult();
    }
    
    
    
}
