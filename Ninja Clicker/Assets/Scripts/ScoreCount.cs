using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int Score;
    public GameObject ScoreText;
    public GameObject AttackText;
    public int InteranalScore;
    public static float CurrentAttack;
    public int CurrentMinNeed;
    private static bool _firstRun = true;

    private void FixedUpdate()
    {
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
