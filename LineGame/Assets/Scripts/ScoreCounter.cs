using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text PlayerScoreText;
    public static ScoreCounter instance;
    public int PlayerScore;
    public  GameObject PanelLevel;
  



    void Start()
    {
        instance = this;
        PlayerScore = 0;
    }


    public void PlayerScoreAdd()
    {
        PlayerScore += 1;
        PlayerScoreText.text = PlayerScore.ToString();
        if(PlayerScore>=3 )
        {
             PanelLevel.SetActive(true); 
        }

       
    }
}

