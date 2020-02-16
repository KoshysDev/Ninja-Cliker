using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAnim : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Anim = new GameObject [1];
    private int RandomPref;
    private Vector2 clickPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Spawn(clickPos);
        }
    }

    void Spawn(Vector2 position)
    {
        RandomPref = Random.Range(0, 2);
        Instantiate(Anim[RandomPref], position, Quaternion.identity);
    }
}
