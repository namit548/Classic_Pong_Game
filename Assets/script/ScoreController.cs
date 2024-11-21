using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject ScoreTextPlayer1;
    public GameObject ScoreTextPlayer2;

    public int goalToWin;

    private void Update()
    {
        if(this.scorePlayer1>= this.goalToWin || this.scorePlayer2>= this.goalToWin)
        {
            Debug.Log("Game Won");
        }
        
    }
     private void FixedUpdate()
    {
        Text uiScoreplayer1 = this.ScoreTextPlayer1.GetComponent<Text>();
        uiScoreplayer1.text = this.scorePlayer1.ToString();

        Text uiScoreplayer2 = this.ScoreTextPlayer1.GetComponent<Text>();
        uiScoreplayer2.text = this.scorePlayer1.ToString();
    }
    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;

    }




}

