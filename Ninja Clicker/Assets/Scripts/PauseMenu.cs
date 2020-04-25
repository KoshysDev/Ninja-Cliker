using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI = null;
    [SerializeField] private GameObject SettingsUI = null;
    [SerializeField] private GameObject PauseButton = null;
    public static bool Death = true;
    public static bool p = false;
    public static bool s = false;
    public GameObject[] EnemyPrefab = new GameObject[1];
    private int RandomPref;

    private void FixedUpdate()
    {
        if(GameObject.FindGameObjectWithTag("Enemy") == false)
        {
            PauseMenu.Death = true;
        }
        EnemySpawner();
    }

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
            this.GetComponent<SettingsMenu>().SaveSettings();
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

    //enemy spawner
    public void EnemySpawner()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == false && PauseMenu.Death == true)
        {
            PauseMenu.Death = false;
            RandomPref = Random.Range(0, EnemyPrefab.Length);
            Instantiate(EnemyPrefab[RandomPref], new Vector3(-0.05f, -1.5f, 3), Quaternion.identity);
        }
    }
}
