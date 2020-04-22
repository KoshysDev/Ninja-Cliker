using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxTouch : MonoBehaviour
{
    public static Vector2 clickPos;
    public GameObject MainCamera;
    private static float _speed = 0.5f;

    public void OnMouseDrag()
    {
        clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 y = new Vector2(clickPos.x / 2, 0);
        //MainCamera.transform.LookAt(y);
        MainCamera.transform.rotation = Quaternion.Slerp(MainCamera.transform.rotation, Quaternion.Euler(0, clickPos.x * 5, 0), _speed * Time.deltaTime);
        //Debug.Log(clickPos.x);
    }
}
