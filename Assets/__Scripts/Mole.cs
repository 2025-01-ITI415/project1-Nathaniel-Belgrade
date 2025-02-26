using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Mole : MonoBehaviour
{

    public ScoreCounter scoreCounter;

    private void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();

    }
    void OnMouseEnter()
    {
        Debug.Log("Yahaha! You found me!");   
    }

    void OnMouseDown()
    {
        //deletes the item from the scene.
        Destroy(this.gameObject);
        scoreCounter.score += 1000;

    }
}
