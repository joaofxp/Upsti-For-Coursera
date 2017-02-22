using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController singleton;
    public GameObject WinPanel;
    public GameObject LosePanel;

    void Awake()
    {
        singleton = this;
    }

    public void PlayerWin()
    {
        WinPanel.SetActive(true);
    }

    public void PlayerLose()
    {
        LosePanel.SetActive(true);
    }

    public void PanelsHide()
    {
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }
}
