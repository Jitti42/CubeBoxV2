using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnterNamePanel : MonoBehaviour
{
    public GameObject namePanel;
    public InputField inputField;
    public string character;
    //public GameObject gameover;
    //public Text nameTag;
    public GameObject Trip;

    public void close()
    {   
        Trip.SetActive(true);
        namePanel.SetActive(false);
        //gameover.SetActive(true);
        character = inputField.text;
        //nameTag.text = character.ToString();
        
        Debug.Log(character);
        
    }

    public void closeTrip()
    {
        Trip.SetActive(false);
    }
   
    
}
