using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Mole : MonoBehaviour
{

    public ScoreCounter scoreCounter;
    public bool inside;

    private void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();

    }
    void OnMouseEnter()
    {
        inside = true;
        Debug.Log("Yahaha! You found me!");
    }

    void OnMouseExit() 
    { 
        inside = false;
        Debug.Log("bye bye!");
    }

    void OnMouseDown()
    {
        if (inside)
        {
            //deletes the item from the scene.
            Destroy(this.gameObject);
            //Adds to total score
            scoreCounter.score += 1000;
            //Sets inside as false again
            inside = false;
        }

    }
}
