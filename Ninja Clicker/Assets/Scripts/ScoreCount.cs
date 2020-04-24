using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int Score;
    public GameObject ScoreText;
    public GameObject AttackText;
    public GameObject[] EnemyPrefab = new GameObject[1];
    private int RandomPref;
    public static bool Death = true;
    public int InteranalScore;
    public static float CurrentAttack;
    public int CurrentMinNeed;
    private static bool _firstRun = true;

    private void FixedUpdate()
    {
        if(GameObject.Find("Enemy") == false && Death == true)
        {
            Death = false;
            RandomPref = Random.Range(0, EnemyPrefab.Length);
            Instantiate(EnemyPrefab[RandomPref], new Vector3(-0.05f, -1.5f, 3), Quaternion.identity);
        }
        if(_firstRun == true)
        {
            GameObject.Find("GameControll").GetComponent<SettingsMenu>().LoadSettings();
            _firstRun = false;
        }
    }

    void Update()
    {
        InteranalScore = Score;
        ScoreText.GetComponent<Text>().text = "" + InteranalScore;
        AttackText.GetComponent<Text>().text = "" + CurrentAttack;
    }
}
