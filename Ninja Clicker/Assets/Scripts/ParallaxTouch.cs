using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxTouch : MonoBehaviour
{
    public static Vector2 clickPos;
    public GameObject MainCamera;
    private static float _speed = 0.5f;
    private static bool _dragTrue = false;

    public void OnMouseDrag()
    {
        _dragTrue = true;
        clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MainCamera.transform.rotation = Quaternion.Slerp(MainCamera.transform.rotation, Quaternion.Euler(0, clickPos.x * 5, 0), _speed * Time.deltaTime);
        _dragTrue = false;
    }

    private void Update()
    {
        if (_dragTrue == false)
        {
            MainCamera.transform.rotation = Quaternion.Slerp(MainCamera.transform.rotation, Quaternion.Euler(0, 0, 0), 1.3f * Time.deltaTime);
        }
    }
}
