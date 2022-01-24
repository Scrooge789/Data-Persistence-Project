using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string playerName;

    private void Awake()
    {
        //This pattern is a singleton. Use it to ensure that only a single instance of the MainManager can ever exist, so it acts as a central point of access.
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
