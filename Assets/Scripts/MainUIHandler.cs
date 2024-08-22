using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentPlayerName;

    private void Start()
    {
       currentPlayerName.text = "Player: " + GetCurrentPlayerName();
    }

    private void Update()
    {
        
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
