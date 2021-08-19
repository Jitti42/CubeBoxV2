using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tuicon;
    public GameObject MenuPanel;
    public GameObject TutoPanel;
    public GameObject aboutPanel;
    // Start is called before the first frame update

    public void menupanel()
    {
        MenuPanel.SetActive(true);
    }

    public void tutotial()
    {
        MenuPanel.SetActive(false);
        TutoPanel.SetActive(true);

    }

    public void aboutus()
    {
        MenuPanel.SetActive(false);
        aboutPanel.SetActive(true);

    }

    public void closetuto()
    {
        MenuPanel.SetActive(true);
        TutoPanel.SetActive(false);

    }

    public void closemenu()
    {
        MenuPanel.SetActive(false);
    }
    public void closeabout()
    {
        MenuPanel.SetActive(true);
        aboutPanel.SetActive(false);

    }

}
