using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnim : MonoBehaviour
{
    public float timer = 1.0f;
    private bool S = false;

    public void DestroyMe()
    {
        Destroy(this.gameObject);
    }

    private void Start()
    {
        S = true;
    }

    private void Update()
    {
        if (S == true && timer >= 0f)
        {
            timer -= 0.1f;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
