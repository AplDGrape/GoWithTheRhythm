using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET_Wall : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Walls
    [SerializeField] GameObject wallRight;
    [SerializeField] GameObject wallLeft;
    [SerializeField] GameObject wallUPRight;
    [SerializeField] GameObject wallUPLeft;
    [SerializeField] GameObject wallPrefab1;

    //Decoratives
    [SerializeField] GameObject lightDeco1;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<ET_GroundSpawner>();
    }

    void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnWall(int CurrentIndexSpawn)
    {
        //Choose which wall to spawn
        GameObject wallToSpawn = wallPrefab1;

        //Choose a point to spawn obstacle
        Transform spawnPoint = transform.GetChild(4).transform;

        //Predetermined Walls
        if (CurrentIndexSpawn == 9)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 11)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 42)
        {
            //Right Wall 2
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallUPRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall 2
            spawnPoint = transform.GetChild(33).transform;
            Instantiate(wallUPLeft, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
