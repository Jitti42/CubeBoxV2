using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MuteControl : MonoBehaviour
{
    public GameObject unmute;
    public GameObject mute;

    // Start is called before the first frame update


    public void Mute()
    {
        unmute.SetActive(false);
        mute.SetActive(true);
    }

    public void Unmute()
    {
        unmute.SetActive(true);
        mute.SetActive(false);
    }
}
