using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject mole;
    public float radius;
    public float spawnrate = 3f;

    private void Start()
    {
        SpawnMole();
    }

    public void SpawnMole()
    {
        Vector3 randompos = Random.insideUnitCircle * radius;
        Instantiate(mole, randompos, Quaternion.identity);
        Invoke("SpawnMole", spawnrate);
    }
}
