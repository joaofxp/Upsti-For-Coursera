using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public GameObject LevelsPanel;
    public GameObject HelpPanel;
    public GameObject CreditsPanel;

    public void ToggleLevelsPanel()
    {
        if (LevelsPanel.activeSelf)
        {
            LevelsPanel.SetActive(false);
            return;
        }

        CreditsPanel.SetActive(false);
        HelpPanel.SetActive(false);
        LevelsPanel.SetActive(true);
    }

    public void ToggleHelpButton()
    {
        if (HelpPanel.activeSelf)
        {
            HelpPanel.SetActive(false);
            return;
        }

        LevelsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        HelpPanel.SetActive(true);
    }

    public void ToggleCreditsButton()
    {
        if (CreditsPanel.activeSelf)
        {
            CreditsPanel.SetActive(false);
            return;
        }

        LevelsPanel.SetActive(false);
        HelpPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }
}
