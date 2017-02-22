using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public static SceneController singleton;

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

    public void Play()
    {
        
    }

    public void LevelChange(string scene)
    {
        SceneManager.LoadScene(scene);
        GameController.singleton.PanelsHide();
    }

    public void LevelRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameController.singleton.PanelsHide();
    }

    public void LevelNext()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        switch (currentScene.name)
        {
            case "Level1":
                SceneController.singleton.LevelChange("Level2");
                break;
            case "Level2":
                SceneController.singleton.LevelChange("Level3");
                break;
            case "Level3":
                SceneController.singleton.LevelChange("Level4");
                break;
            case "Level4":
                SceneController.singleton.LevelChange("Level5");
                break;
            case "Level5":
                SceneController.singleton.LevelChange("Level6");
                break;
            case "Level6":
                SceneController.singleton.LevelChange("Level7");
                break;
            case "Level7":
                SceneController.singleton.LevelChange("Level8");
                break;
            case "Level8":
                SceneController.singleton.LevelChange("Level9");
                break;
            case "Level9":
                SceneController.singleton.LevelChange("Level10");
                break;
            case "Level10":
                SceneController.singleton.LevelChange("Menu");
                break;
            default:
                break;
        }
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
