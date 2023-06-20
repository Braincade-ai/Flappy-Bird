using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HighScore" + highscore.ToString(); ;


    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
