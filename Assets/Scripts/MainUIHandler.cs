using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentPlayerName;
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] MainManager mainManager;
    [SerializeField] int maxScore = 0;


    private void Start()
    {
        currentPlayerName.text = "Player: " + GetCurrentPlayerName();
       
    }

    private void Update()
    {
        int score = mainManager.m_Points;
        
        if (score > maxScore)
        {
            maxScore = score;
            GameManager.Instance.maxScoreName = GetCurrentPlayerName();
            GameManager.Instance.maxScore = maxScore;
        }

        bestScoreText.text = "Best Score: " + GameManager.Instance.maxScoreName + "-" + GameManager.Instance.maxScore;
        maxScore = GameManager.Instance.maxScore;
        
    }

    private string GetCurrentPlayerName()
    {
        if (GameManager.Instance.playerName != "")
        {
            return GameManager.Instance.playerName;
        }
        else 
        {
            return "Anonymous";
        }
    }

}
