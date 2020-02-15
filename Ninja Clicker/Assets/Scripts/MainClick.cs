using System.Collections;
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
    int i = 8;
    private float timer = 0.0f;

    private void OnMouseDown()
    {
        health -= 0.1f / MobHealth * 100f;
    }

    private void Start()
    {
        Attack = ScoreCount.CurrentAttack;
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
            ScoreCount.Death = true;
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
