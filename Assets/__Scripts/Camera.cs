using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public enum Direction { north, south, east, west }

    [Header("Dynamic")]
    public Direction camDIR = Direction.north;
    

}
