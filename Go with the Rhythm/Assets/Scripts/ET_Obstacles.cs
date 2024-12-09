using System.Collections;
using UnityEngine;

public class ET_Obstacles : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Obstacles
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] GameObject ElectricObstaclePrefab;

    [SerializeField] float tallObstacleChance = 0.2f;
    [SerializeField] float electricObstacleChance = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<ET_GroundSpawner>();
        //SpawnObstacle();
    }

    void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public IEnumerator SpawnObstacle(int CurrentNodeSpawn)
    {
        //Choose which obstacle to spawn
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 2f);

        //Choose random point to spawn obstacle
        int obstacleSpawnIndex = Random.Range(2, 16);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        //Delay Spawn
        yield return new WaitForSeconds(10);

        //Predetermined Spawned obstacles
        if (CurrentNodeSpawn == 7)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 9)
        {
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 11)
        {
            spawnPoint = transform.GetChild(13).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 13)
        {
            spawnPoint = transform.GetChild(13).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 15)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 16)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 18)
        {
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(29).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Pattern
        else if (CurrentNodeSpawn == 19 || CurrentNodeSpawn == 20)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 22)
        {
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(30).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 23 || CurrentNodeSpawn == 24)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 26)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Chorus
        else if (CurrentNodeSpawn == 34 || CurrentNodeSpawn == 35)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 36)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 37 || CurrentNodeSpawn == 38 || CurrentNodeSpawn == 42 || CurrentNodeSpawn == 53 || CurrentNodeSpawn == 54)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 40)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 41 || CurrentNodeSpawn == 49 || CurrentNodeSpawn == 50)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 44)
        {
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(29).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 46)
        {
            spawnPoint = transform.GetChild(7).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 48)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 52)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 56)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Chorus End
        else if (CurrentNodeSpawn == 57)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 58)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 60)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 61)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 62)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 64)
        {
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 66 || CurrentNodeSpawn == 67 || CurrentNodeSpawn == 74 || CurrentNodeSpawn == 75)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 68)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(29).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 70)
        {
            spawnPoint = transform.GetChild(7).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(14).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(29).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(13).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 72)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(16).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(30).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 76)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 78 || CurrentNodeSpawn == 80)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(16).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 79)
        {
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Chorus
        else if (CurrentNodeSpawn == 82)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 83)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 84)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(16).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 86 || CurrentNodeSpawn == 87 || CurrentNodeSpawn == 90 || CurrentNodeSpawn == 98 || CurrentNodeSpawn == 103)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 88)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 91 || CurrentNodeSpawn == 99 || CurrentNodeSpawn == 102)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 92)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 94)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 96)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(16).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Chorus End
        else if (CurrentNodeSpawn == 108)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(12).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 112)
        {
            spawnPoint = transform.GetChild(10).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(16).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(15).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(5).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(8).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(6).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(9).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 116 || CurrentNodeSpawn == 120)
        {
            spawnPoint = transform.GetChild(7).transform;
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            if (random < tallObstacleChance)
            {
                obstacleToSpawn = tallObstaclePrefab;
            }
            else if (random < electricObstacleChance)
            {
                obstacleToSpawn = ElectricObstaclePrefab;
            }

            //Spawn the obstacle at the position
            //Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
        }

        //Spawn the obstacle at the position
        //Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
    }
}
