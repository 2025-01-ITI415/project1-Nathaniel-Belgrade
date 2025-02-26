using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    void OnMouseEnter()
    {
        Debug.Log("Yahaha! You found me!");   
    }

    void OnMouseDown()
    {

        //deletes the item from the scene.
        Destroy(this.gameObject);

    }
}
