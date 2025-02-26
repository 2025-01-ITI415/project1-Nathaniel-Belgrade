using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static List<GameObject> inventory;


    public void AddToInventory(GameObject item)
    {
        Debug.Log("Added To List");
        inventory.Add(item);
    }


}
