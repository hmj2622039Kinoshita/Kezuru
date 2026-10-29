using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Pickaxe : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] TextMeshProUGUI oreText;
    [SerializeField] float rockRange = 3.0f;
    [SerializeField] float rotation = 20f; // ‰Šúrotation
    public static bool swing = false; // ƒcƒ‹ƒnƒV‚ðU‚è‰º‚ë‚·
    public static bool back = false; // –ß‚·
    public static int oreCount = 0;

    public void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && swing == false)
        {
            swing = true;
            back = false;
        }
        if(swing==true)
        {
            if(back==false)
            {
                rotation = Mathf.MoveTowards(rotation, 90f, Time.deltaTime * 600f);
                if(rotation >=90)
                {
                    back = true;

                    Collider[] rocks = Physics.OverlapSphere(player.position, rockRange);

                    foreach(Collider rock in rocks)
                    {
                        if (rock.CompareTag("Rock"))
                        {
                            oreCount++;
                            oreText.text = "" + oreCount;
                            break;
                        }
                    }
                }
            }
            else
            {
                rotation = Mathf.MoveTowards(rotation, 20f, Time.deltaTime * 600f);
                if(rotation<=20f)
                {
                    rotation = 20f;
                    swing = false;
                    back = false;
                }
            }
           transform.localRotation = Quaternion.Euler(0, 90f, rotation);
        }
    }
}
