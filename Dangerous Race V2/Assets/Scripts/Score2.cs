using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public Text score;
    public Text highScore;


    float myScore = 0;
    public float scoreSpeedTime = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score:";
        highScore.text = PlayerPrefs.GetInt("HightScore", 0).ToString();
    }

    // Update is called once per frame
    

    private void Update()
    {
        myScore += Time.deltaTime * scoreSpeedTime;
        score.text = (int)myScore + " Km";

        if (myScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", myScore);
            highScore.text = "HighScore: " + (int)myScore;
        }
    }
}