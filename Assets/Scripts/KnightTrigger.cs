using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knight")
        {
            door.GetComponent<OpenDoor>().check += 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Knight")
        {
            if (door.GetComponent<OpenDoor>().check > 0)
            {
                door.GetComponent<OpenDoor>().check -= 1;
            }
        }
    }
}
