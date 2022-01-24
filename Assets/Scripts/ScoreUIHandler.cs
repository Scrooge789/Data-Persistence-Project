using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class ScoreUIHandler : MonoBehaviour
{
    public Text highScoreText;
    int highScore;
    string bestPlayer;


    // Start is called before the first frame update
    void Start()
    {
        LoadHighScore();
        highScoreText.text = "" + bestPlayer + ": " + highScore;
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public int playerScore;
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.playerScore;
            bestPlayer = data.playerName;
        }
    }

}
