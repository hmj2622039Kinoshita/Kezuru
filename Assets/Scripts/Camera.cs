using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player; // playerのtransform入れ
    [SerializeField] float sensitivity = 2.0f;
    [SerializeField] float rotationX = 0f;

    float py; // 視点操作用のy 

    private void Start()
    {
        rotationX = transform.localEulerAngles.x;
        if(rotationX>180f)
        {
            rotationX -= 360f;
        }
    }
    private void Update()
    {
        py = Input.GetAxis("Mouse Y"); // カーソルの縦の移動量の取得
        if (Mathf.Abs(py) > 0.001f) // 縦方向の視点移動
        {
            transform.RotateAround(player.transform.position, Vector3.right, -py);
        }
    }
}
