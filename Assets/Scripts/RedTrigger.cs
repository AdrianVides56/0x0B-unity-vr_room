using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTrigger : MonoBehaviour
{
    int result = 9, check = 0;
    [SerializeField] GameObject door;

    void Update()
    {
        if (check == result)
        {
            door.GetComponent<OpenSecondDoor>().redCheck = true;
        }
        else
        {
            door.GetComponent<OpenSecondDoor>().redCheck = false;
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "aux")
            check += 1;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "aux")
        {
            if (check > 0)
                check -= 1;
        }
    }
}
