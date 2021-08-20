using System;
using System.Collections;
using System.Collections.Generic;
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
        
        if(score == 10||score ==25||score ==40||score ==55||score ==70||score ==85||score ==100||score ==115||score ==130||score ==145||
        score ==160||score ==175||score ==190||score ==205||score ==220||score ==235||score ==250||score ==265||score ==280||score ==295||
        score ==310||score ==325||score ==340||score ==355||score ==370||score ==385||score ==400||score ==415||score ==430||score ==445||
        score ==460||score ==475||score ==490||score ==505||score ==520||score ==535||score ==550||score ==565||score ==580||score ==595||
        score ==610||score ==625||score ==640||score ==655||score ==670||score ==685||score ==700||score ==715||score ==730||score ==745||
        score ==760||score ==775||score ==790||score ==805||score ==820||score ==835||score ==850||score ==865||score ==880||score ==895||
        score ==910||score ==925||score ==940||score ==955||score ==970||score ==985||score ==1000)
        {
            
            scene.LoadScene();

        }
        
    }

    public void plusScore()
    {
        
        score++;
        scoretext.text = score.ToString();
        if(score == 15||score ==30||score ==45||score ==60||score ==75||score ==90||score ==105||score ==120||score ==135||score ==150||
        score ==165||score ==180||score ==195||score ==210||score ==225||score ==240||score ==255||score ==270||score ==285||score ==300||
        score ==315||score ==330||score ==345||score ==360||score ==375||score ==390||score ==405||score ==420||score ==435||score ==450||
        score ==465||score ==480||score ==495||score ==510||score ==525||score ==540||score ==555||score ==570||score ==585||score ==600||
        score ==615||score ==630||score ==645||score ==660||score ==675||score ==690||score ==705||score ==720||score ==735||score ==750||
        score ==765||score ==780||score ==795||score ==810||score ==825||score ==840||score ==855||score ==870||score ==885||score ==900||
        score ==915||score ==930||score ==945||score ==960||score ==975||score ==990||score ==995)
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
