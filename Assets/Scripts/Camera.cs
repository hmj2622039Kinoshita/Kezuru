using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float sensitivity = 2.0f;
    [SerializeField] float rotationX = 0f;

    float py; // 視点操作用のy 

    private void Start()
    {
        rotationX = transform.localEulerAngles.x;
        if (rotationX > 180f)
        {
            rotationX -= 360f;
        }
    }
    private void Update()
    {
        py = Input.GetAxis("Mouse Y") * sensitivity; // カーソルの縦の移動量の取得

        rotationX -= py;
        rotationX = Mathf.Clamp(rotationX, -80f, 80f);
        transform.localRotation =Quaternion.Euler(rotationX, 0, 0);
    }
}
