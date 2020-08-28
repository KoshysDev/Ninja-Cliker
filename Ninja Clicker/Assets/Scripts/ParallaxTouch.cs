using UnityEngine;

public class ParallaxTouch : MonoBehaviour
{
    private static Vector2 _сlickPos;
    public GameObject mainCamera;
    private const float Speed = 0.5f;
    private static bool _dragTrue = false;

    public void OnMouseDrag()
    {
        _dragTrue = true;
        if (Camera.main != null) _сlickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(0, _сlickPos.x * 5, 0), Speed * Time.deltaTime);
        _dragTrue = false;
    }

    private void Update()
    {
        if (_dragTrue == false)
        {
            mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, Quaternion.Euler(0, 0, 0), 1.3f * Time.deltaTime);
        }
    }
}
