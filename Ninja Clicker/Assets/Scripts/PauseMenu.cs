using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI;
    private bool p = false;

    public void OnExit()
    {
     Application.Quit();
    }

    public void OnPlay()
    {
        if (p == false)
        {
            PauseMenuUI.SetActive(true);
            p = true;
        }
        else
        {
            PauseMenuUI.SetActive(false);
            p = false;
        }
    }
}
