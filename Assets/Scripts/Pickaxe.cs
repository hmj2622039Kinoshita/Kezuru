using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pickaxe : MonoBehaviour
{
    private float angle = 20f;
    private bool swing = false;
    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            swing = true;
        }
        if(swing)
        {
            if(angle<90)
            {
                angle = Mathf.Lerp(angle, 90, Time.deltaTime * 15);
            }
            else
            {
                angle = Mathf.Lerp(angle, 20, Time.deltaTime * 15);
            }
            transform.localRotation = Quaternion.Euler(0, 0, angle);

            if(angle <21 && angle>19)
            {
                angle = 20;
                swing = false;
            }
        }
    }
}
