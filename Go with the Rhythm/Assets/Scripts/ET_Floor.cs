using System;
using UnityEngine;

public class ET_Floor : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Floor
    [SerializeField] GameObject floorPrefab;
    [SerializeField] GameObject emptyfloorPrefab;

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
        //Choose which floor to spawn
        GameObject floorToSpawn = floorPrefab;

        //Choose a point to spawn obstacle
        Transform spawnPoint = transform.GetChild(4).transform;

        //Predetermined Floors
        if (CurrentIndexSpawn == 37)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 75)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 91)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 110)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 111 || CurrentIndexSpawn == 115)
        {
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 114)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 116 || CurrentIndexSpawn == 124)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 117)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 120 || CurrentIndexSpawn == 128)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 121)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 125 || CurrentIndexSpawn == 126 || CurrentIndexSpawn == 129 || CurrentIndexSpawn == 130)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 131)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 132 || CurrentIndexSpawn == 133)
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(emptyfloorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            //Front half of the floors
            spawnPoint = transform.GetChild(17).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(18).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(19).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Front middle path of floors
            spawnPoint = transform.GetChild(20).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(21).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(22).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle path of the floors
            spawnPoint = transform.GetChild(23).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(24).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(25).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            //Middle bottom path of the floors
            spawnPoint = transform.GetChild(26).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(27).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(28).transform;
            Instantiate(floorPrefab, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
