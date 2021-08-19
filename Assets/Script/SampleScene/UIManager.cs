using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public GameObject hudPanel;
    public GameObject resultPanel;
    public GameObject PausePanel;
    public GameObject iconscore;
    public SampleScene scene;
    public BonusScene Bscene;
    //public GameObject namePanel;
    //HUD
    public Text scoretext;
    static int score = 0;

    //Result
    public Text currentScoreText;
    public Text bestScoreText;
    public Text pauseScore;
    //public Text Nametag;


    public Fryerz fry;
    public float speed;
    //pauseGame
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;


    public void start()
    {
        scoretext.text = score.ToString();
    }
    
    

    public void Pause()
    {
        pause();
        iconscore.SetActive(false);
        PausePanel.SetActive(true);
        pauseScore.text = score.ToString();

    }
    
    public void resume()
    {
        Resume();
        iconscore.SetActive(true);
        PausePanel.SetActive(false);

    }

   void Resume()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void pause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameisPaused = true;
    }


    public void IncreaseScore()
    {

        score++;
        scoretext.text = score.ToString();
        

        if (score == 10)
        {
            
            scene.LoadScene();

        }
        else if(score == 25)
        {
            scene.LoadScene();
        }
    }

    public void plusScore()
    {
        
        score++;
        scoretext.text = score.ToString();
        if(score == 15)
        {
            Bscene.LoadScene();

        }
        else if(score == 30)
        {
            Bscene.LoadScene();
        }
        
    }

    public void OneClick()
    {
        Resume();
   
    }

    public void ShowResult()
    {
        pause();
        hudPanel.SetActive(false);
        resultPanel.SetActive(true);
        pauseMenuUI.SetActive(true);
        //namePanel.SetActive(true);
        currentScoreText.text = score.ToString();

        int bestScore = PlayerPrefs.GetInt("BestScore");
        bestScoreText.text = bestScore.ToString();
        if(score>bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            
        }
    }
    public void OnReplayClick()
    {
        Resume();
        score = 0;
        int level = Application.loadedLevel;
        Application.LoadLevel(level);
    }

    public void restart()
    {
        score = 0;
        Bscene.LoadScene();
    }

    void update()
    {
        scoretext.text = score.ToString();
    }
}
