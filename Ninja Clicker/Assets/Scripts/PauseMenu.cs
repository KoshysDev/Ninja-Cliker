﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI = null;
    [SerializeField] private GameObject SettingsUI = null;
    [SerializeField] private GameObject PauseButton = null;
    public static bool p = false;
    public static bool s = false;

    public void OnExit()
    {
     Application.Quit();
    }

    public void OnPlay()
    {
        if (p == false)
        {
            PauseMenuUI.SetActive(true);
            PauseButton.SetActive(false);
            p = true;
        }
        else
        {
            PauseMenuUI.SetActive(false);
            PauseButton.SetActive(true);
            p = false;
        }
    }

    public void Settings()
    {
        if (s == false && p == true)
        {
            SettingsUI.SetActive(true);
            PauseMenuUI.SetActive(false);
            s = true;
        }
        else
        {
            PauseMenuUI.SetActive(true);
            SettingsUI.SetActive(false);
            s = false;
        }
    }

    public void RedirectDiscord()
    {
        Application.OpenURL("https://discord.gg/ujyhnDP");
    }
}