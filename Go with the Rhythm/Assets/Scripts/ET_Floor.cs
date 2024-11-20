using System;
using UnityEngine;

public class ET_Floor : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Floor
    [SerializeField] GameObject floorPrefab;

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

    public void SpawnFloor(int CurrentIndexSpawn)
    {
        //Choose which obstacle to spawn
        GameObject floorToSpawn = floorPrefab;

        //Choose a point to spawn obstacle
        Transform spawnPoint = transform.GetChild(4).transform;

        //Predetermined Floors
        if (CurrentIndexSpawn == 37)
        {
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 75)
        {
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 92)
        {
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
