using UnityEngine;
using UnityEngine.Serialization;

public class HealthBar : MonoBehaviour
{
    public Transform bar;
    public SpriteRenderer spriteRenderer;

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void SetColore(Color color)
    {
        spriteRenderer.color = color;
    }
}
