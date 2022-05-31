using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenDoor : MonoBehaviour
{
    public int check = 0;
    [SerializeField] GameObject hallFloor1, hallFloor2;

    // Update is called once per frame
    void Update()
    {
        if (check == 3)
        {
            GetComponent<Animator>().SetBool("character_nearby", true);
            hallFloor1.GetComponent<TeleportationArea>().enabled = true;
            hallFloor2.GetComponent<TeleportationArea>().enabled = true;
        }
        else
        {
            GetComponent<Animator>().SetBool("character_nearby", false);
            hallFloor1.GetComponent<TeleportationArea>().enabled = false;
            hallFloor2.GetComponent<TeleportationArea>().enabled = false;
        }
    }
}
