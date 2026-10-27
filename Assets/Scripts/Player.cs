using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody rb; // Rigidbody入れ
    [SerializeField] float speed = 0.05f; // 移動速度

    float px; // 視点操作用のx
    float py; // 視点操作用のy 

    private void Update()
    {
        // 移動
        Vector3 move = Vector3.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position += transform.forward * speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.position -= transform.forward * speed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= transform.right * speed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += transform.right * speed;
        }

        // マウスカーソルでの視点操作
        px = Input.GetAxis("Mouse X"); // カーソルの横の移動量の取得
        if (Mathf.Abs(px) > 0.001f) // 横方向の視点移動
        {
            transform.RotateAround(transform.position, Vector3.up, px);
        }
        
    }
}
