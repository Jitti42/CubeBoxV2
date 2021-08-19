using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D c)
    {
        
        Destroy(this.gameObject);
    }

    
}
