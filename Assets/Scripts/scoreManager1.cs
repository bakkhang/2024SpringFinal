using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

     public Text scoreText;
   // public Text highscoreText;

    int score = 0;
    //int highscore = 0;

    private void Awake()
    { Instance = this; 
    }

    void Start()
    {
       
        scoreText.text = score.ToString() + " POINTS";
       //highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void Addpoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
        if(score >=5)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
