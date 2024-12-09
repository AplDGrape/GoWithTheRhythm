using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET_Wall : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Wall
    [SerializeField] GameObject wallPrefab1;
    [SerializeField] GameObject wallPrefab2;

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
        if (CurrentIndexSpawn == 42)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallPrefab2, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallToSpawn, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
