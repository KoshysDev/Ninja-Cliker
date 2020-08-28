using UnityEngine;

public class ButtonUpdate : MonoBehaviour
{
    public int minNeed = 20;
    public int plusBuy;
    public float plusAttack = 0.01f;

    // ReSharper disable once UnusedMember.Global
    public void ClickTheButton()
    {
        if (ScoreCount.Score < minNeed) return;
        ScoreCount.Score -= minNeed;
        ScoreCount.CurrentAttack += plusAttack;
        MainClick.Attack += plusAttack;
        minNeed += plusBuy;
    }
}
