using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void StartNew()
    {
        GameManager.Instance.LoadScore();
        GameManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1);
        Debug.Log(GameManager.Instance.playerName);
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
    }
}
