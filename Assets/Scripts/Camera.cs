using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject player; // playerのオブジェクト入れ

    float py; // 視点操作用のy 

    private void Update()
    {
        py = Input.GetAxis("Mouse Y"); // カーソルの縦の移動量の取得
        if (Mathf.Abs(py) > 0.001f) // 縦方向の視点移動
        {
            transform.RotateAround(player.transform.position, Vector3.right, -py);
        }
    }
}
