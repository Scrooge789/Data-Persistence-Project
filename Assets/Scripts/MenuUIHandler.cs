using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject enterName;
    [SerializeField] InputField userNameInputText;

    public void StartNew()
    {
        GameManager.Instance.playerName = userNameInputText.GetComponent<InputField>().text;
        SceneManager.LoadScene(1);
    }

    public void EnterName()
    {
        enterName.SetActive(true);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ScoreBoard()
    {
        SceneManager.LoadScene(2);
    }
}
