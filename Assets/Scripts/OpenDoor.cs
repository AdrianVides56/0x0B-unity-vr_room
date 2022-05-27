using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int count, check;
    public string socketName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CheckPiece(GameObject piece)
    {
        if (piece.name == socketName)
            Debug.Log(piece.name + socketName);
            augmentCount();
    }


    public void NextCorridor()
    {
        
    }

    public void augmentCount() => count++;
}
