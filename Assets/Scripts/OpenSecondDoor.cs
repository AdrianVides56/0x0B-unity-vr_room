using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecondDoor : MonoBehaviour
{
    public int check = 0;
    public bool blueCheck = false, greenCheck = false, redCheck = false;

    void Update()
    {
        if (blueCheck && greenCheck && redCheck)
        {
            GetComponent<Animator>().SetBool("character_nearby", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("character_nearby", false);
        }
    }
}
