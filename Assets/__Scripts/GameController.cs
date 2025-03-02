using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject mole;
    public GameObject Wall;
    public float radius;
    public float spawnrate = 3f;
    private Vector3 randomPos;
    private float xCoord;
    private float yCoord;
    private float zCoord;

    private void Start()
    {
        SpawnMole();
    }

    public void SpawnMole()
    {
        switch (Wall.tag)
        {
            case ("North"):
                xCoord = Random.Range(-8.9f, 8.8f);
                yCoord = Random.Range(-3.9f, 5.6f);
                randomPos.Set(xCoord, yCoord, 0.35f);
                Instantiate(mole, randomPos, Quaternion.identity);
                Invoke("SpawnMole", spawnrate);
                break;
            case ("South"):
                xCoord = Random.Range(-8.9f, 8.8f);
                yCoord = Random.Range(-3.9f, 5.6f);
                randomPos.Set(xCoord, yCoord, -19.6f);
                Instantiate(mole, randomPos, Quaternion.identity);
                Invoke("SpawnMole", spawnrate);
                break;
            case ("East"):
                yCoord = Random.Range(-4f, 5.85f);
                zCoord = Random.Range(-18.3f, -1.2f);
                randomPos.Set(10f, yCoord, zCoord);
                Instantiate(mole, randomPos, Quaternion.identity);
                Invoke("SpawnMole", spawnrate);
                break;
            case ("West"):
                yCoord = Random.Range(-4f, 5.85f);
                zCoord = Random.Range(-18.3f, -1.2f);
                randomPos.Set(-10f, yCoord, zCoord);
                Instantiate(mole, randomPos, Quaternion.identity);
                Invoke("SpawnMole", spawnrate);
                break;

        }
    }
}