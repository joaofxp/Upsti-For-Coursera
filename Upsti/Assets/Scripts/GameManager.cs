using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public GameObject WinPanel;
    public GameObject LosePanel;

    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

    public void PlayerWin()
    {
        WinPanel.SetActive(true);
    }

    public void PlayerLose()
    {
        LosePanel.SetActive(true);
    }

    public void LevelChange(string scene)
    {
        SceneManager.LoadScene(scene);
        PanelsHide();
    }

    public void LevelRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PanelsHide();
    }

    public void PanelsHide()
    {
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }
}
