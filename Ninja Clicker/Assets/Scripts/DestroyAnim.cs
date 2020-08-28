using UnityEngine;

public class DestroyAnim : MonoBehaviour
{
    public float timer = 1.0f;
    private bool _s;

    public void DestroyMe()
    {
        Destroy(this.gameObject);
    }

    private void Start()
    {
        _s = true;
    }

    private void Update()
    {
        if (_s == true && timer >= 0f)
        {
            timer -= 0.1f;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
