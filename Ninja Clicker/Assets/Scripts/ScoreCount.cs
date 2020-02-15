﻿using System.Collections;
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
    public int InteranalScore;
    public float CurrentAttack;
    public int CurrentMinNeed;
    private float i = 0.0f;

    private void FixedUpdate()
    {
        if (i >= 1.0f)
        {
            Score += 1;
            i = 0;
        }
        else
        {
            i += CurrentAttack;
        }

        if(MainClick.death == true)
        {
            RandomPref = Random.Range(0, 12);
            Instantiate(EnemyPrefab[RandomPref], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    private void Start()
    {

        Vector3 SpawnPosition = GameObject.Find("Enemy").transform.position;
    }

    void Update()
    {
        CurrentAttack = MainClick.Attack;
        InteranalScore = Score;
        ScoreText.GetComponent<Text>().text = "Score: " + InteranalScore;
        AttackText.GetComponent<Text>().text = "Attack: " + CurrentAttack;
    }
}
