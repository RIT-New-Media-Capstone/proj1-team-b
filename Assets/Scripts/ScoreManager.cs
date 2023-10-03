using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Using code from Coco Code on Youtube: https://www.youtube.com/watch?v=YUcvy9PHeXs&ab_channel=CocoCode

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text p1ScoreText;
    public Text p2ScoreText;

    int player1Score = 0;
    int player2Score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        p1ScoreText.text = player1Score.ToString();

        p2ScoreText.text = player2Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Add a point to given player's score 
    public void AddPoint(Text player, int score)
    {
        score += 1;
        player.text = score.ToString();
    }
}
