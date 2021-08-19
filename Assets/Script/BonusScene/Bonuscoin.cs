using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuscoin : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D c)
    {
        Destroy(this.gameObject);
    }
}
