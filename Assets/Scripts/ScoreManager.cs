using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int highscore = 0;
    public static int Score = 0;

    // Use this for initialization
    void Start()
    {

        Score = score.getpincount();
        highscore = PlayerPrefs.GetInt("highscores", highscore);
        GameObject.FindWithTag("score").GetComponent<Text>().text = "High Score : " + highscore.ToString();
        GameObject.FindWithTag("dscore").GetComponent<Text>().text = Score.ToString();


    }

    // Update is called once per frame
    void Update()
    {



        if (Score > highscore)
        {
            highscore = Score;

            GameObject.FindWithTag("score").GetComponent<Text>().text = "High Score : " + highscore.ToString();
            PlayerPrefs.SetInt("highscores", highscore);



        }
    }




}