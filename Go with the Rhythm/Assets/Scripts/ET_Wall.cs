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
    [SerializeField] GameObject wallChorusR;
    [SerializeField] GameObject wallChorusL;
    [SerializeField] GameObject wallDOWNRight;
    [SerializeField] GameObject wallDOWNLeft;
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
        if (CurrentIndexSpawn == 9 || CurrentIndexSpawn == 10)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 11 || CurrentIndexSpawn == 12)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 13 || CurrentIndexSpawn == 14)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(38).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn >= 15 && CurrentIndexSpawn <= 41)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(36).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(38).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(39).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn >= 68 && CurrentIndexSpawn <= 90)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(36).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(38).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(39).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn >= 115 && CurrentIndexSpawn <= 140)
        {
            //Right Wall
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall
            spawnPoint = transform.GetChild(32).transform;
            Instantiate(wallLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(36).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(38).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(39).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 42 || CurrentIndexSpawn == 91)
        {
            //Right Wall 2
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallUPRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall 2
            spawnPoint = transform.GetChild(33).transform;
            Instantiate(wallUPLeft, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn >= 43 && CurrentIndexSpawn <= 66)
        {
            //Right Wall 2
            spawnPoint = transform.GetChild(40).transform;
            Instantiate(wallChorusR, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall 2
            spawnPoint = transform.GetChild(41).transform;
            Instantiate(wallChorusL, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn >= 92 && CurrentIndexSpawn <= 113)
        {
            //Right Wall 2
            spawnPoint = transform.GetChild(40).transform;
            Instantiate(wallChorusR, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall 2
            spawnPoint = transform.GetChild(41).transform;
            Instantiate(wallChorusL, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentIndexSpawn == 67 || CurrentIndexSpawn == 114)
        {
            //Right Wall 2
            spawnPoint = transform.GetChild(31).transform;
            Instantiate(wallDOWNRight, spawnPoint.position, Quaternion.identity, transform);
            //Left Wall 2
            spawnPoint = transform.GetChild(33).transform;
            Instantiate(wallDOWNLeft, spawnPoint.position, Quaternion.identity, transform);

            //Decoratives
            //R
            spawnPoint = transform.GetChild(34).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(35).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(36).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            //L
            spawnPoint = transform.GetChild(37).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(38).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(39).transform;
            Instantiate(lightDeco1, spawnPoint.position, Quaternion.identity, transform);
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
