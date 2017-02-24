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
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

    public void PlayerWin()
    {
        if (!LosePanel.activeSelf)
        {
            WinPanel.SetActive(true);
        }
    }

    public void PlayerLose()
    {
        if (!WinPanel.activeSelf)
        {
            LosePanel.SetActive(true);
        }
    }

    public void PanelsHide()
    {
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }
}
