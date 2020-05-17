﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainClick : MonoBehaviour
{
    [SerializeField] public HealthBar healthBar;
    public static float Attack = 0.0f;
    public float health = 1.0f;
    public float MobHealth = 100.0f;
    public int Pay;
    public int XP;
    public int CurrentLelvel;
    int i = 8;
    public GameObject[] Anim = new GameObject[1];
    public AudioClip[] Audio = new AudioClip[3];
    public AudioSource AudioS;
    private static int RandomPref;
    private static GameObject MainCamera;
    private float timer = 0.0f;
    public static Vector2 clickPos;
    public static bool IfSoundOn = true;

    public void UpdateXp(int xp)
    {
        XP += xp;
        int CurLvl = (int)(0.1f * Mathf.Sqrt(XP));
        if(CurLvl != CurrentLelvel)
        {
            CurrentLelvel = CurLvl;
            //TODO: Add lvlup anim
        }
        int XpToNextLvl = 100 * (CurrentLelvel + 1) * (CurrentLelvel + 1);
        int Difference = XpToNextLvl - XP;
        int TotalDifference = XpToNextLvl - (100 * CurrentLelvel * CurrentLelvel);
    }

    private void OnMouseDown()
    {
        if (PauseMenu.p == false)
        {
            health -= 0.1f / MobHealth * 100f;
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Spawn(clickPos);
            if(IfSoundOn == true)
            {
                RandomSound();
            }
        }
    }

    void Spawn(Vector2 position)
    {
        RandomPref = Random.Range(0, Anim.Length);
        Instantiate(Anim[RandomPref], position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
    }

    void RandomSound()
    {
        AudioS.clip = Audio[Random.Range(0, Audio.Length)];
        AudioS.Play();
    }

    private void Start()
    {
        Attack = ScoreCount.CurrentAttack;
        MainCamera = GameObject.Find("Main Camera");
    }

    private void Update()
    {

        if (timer >= 1.0f)
        {
            health -= Attack;
            timer = 0;
        }
        else
        {
            timer += 0.01f;
        }

        if (health <= 0f)
        {
            ScoreCount.Score += Pay;
            PauseMenu.Death = true;
            Destroy(this.gameObject);
        }

        healthBar.SetSize(health);
        if(health <= 0.3f)
        {
            if(i <= 0)
            {
                healthBar.SetColore(Color.white);
                i = 8;
            } else {
                healthBar.SetColore(Color.red);
                i--;
            }
        }
    }
}
