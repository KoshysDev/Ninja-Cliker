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

    private void FixedUpdate()
    {
        if(GameObject.Find("Enemy") == false && Death == true)
        {
            Death = false;
            RandomPref = Random.Range(0, EnemyPrefab.Length);
            Instantiate(EnemyPrefab[RandomPref], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    void Update()
    {
        InteranalScore = Score;
        ScoreText.GetComponent<Text>().text = "" + InteranalScore;
        AttackText.GetComponent<Text>().text = "" + CurrentAttack;
    }
}
