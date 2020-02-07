using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score3 : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;

    public float speedScore =1;
    float score;
    int highScore;
    


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * speedScore;
        highScore = (int)score;
        scoreText.text = highScore.ToString() + " KM";

        if (PlayerPrefs.GetInt("score") <= highScore)
            PlayerPrefs.SetInt("score", highScore);
        highScoreText.text = "Personal Best: " + PlayerPrefs.GetInt("score").ToString() + " KM";

    }
}
