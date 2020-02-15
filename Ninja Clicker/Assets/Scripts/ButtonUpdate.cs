using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUpdate : MonoBehaviour
{
    public int minNeed = 20;
    public int PlusBuy;
    public float PlusAtack = 0.01f;

    public void ClickTheButton()
    {
        if (ScoreCount.Score >= minNeed)
        {
            ScoreCount.Score -= minNeed;
            ScoreCount.CurrentAttack += PlusAtack;
            MainClick.Attack += PlusAtack;
            minNeed += PlusBuy;

        }
    }
}
