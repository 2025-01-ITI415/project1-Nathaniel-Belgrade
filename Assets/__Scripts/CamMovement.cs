using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    public void turnLeft()
    {
        transform.Rotate(0, -45, 0);
    }

    public void turnRight()
    {
        transform.Rotate(0, 45, 0);
    }

}
