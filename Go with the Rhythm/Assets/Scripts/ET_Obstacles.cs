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

    public void SpawnObstacle(int CurrentNodeSpawn)
    {
        //Choose which obstacle to spawn
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 2f);

        //Choose random point to spawn obstacle
        int obstacleSpawnIndex = Random.Range(2, 16);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        //Predetermined Spawned obstacles
        if (CurrentNodeSpawn == 7)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 9)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 11)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 13)
        {
            spawnPoint = transform.GetChild(11).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
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
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Pattern
        else if (CurrentNodeSpawn == 19 || CurrentNodeSpawn == 20 || CurrentNodeSpawn == 23 || CurrentNodeSpawn == 24)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 22 || CurrentNodeSpawn == 26)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        //Chorus
        else if (CurrentNodeSpawn == 34 || CurrentNodeSpawn == 35)
        {
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 36 || CurrentNodeSpawn == 40 || CurrentNodeSpawn == 44 || CurrentNodeSpawn == 46 || CurrentNodeSpawn == 48 || CurrentNodeSpawn == 52 || CurrentNodeSpawn == 56)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 37 || CurrentNodeSpawn == 38 || CurrentNodeSpawn == 41 || CurrentNodeSpawn == 42 || CurrentNodeSpawn == 49 || CurrentNodeSpawn == 50 || CurrentNodeSpawn == 53 || CurrentNodeSpawn == 54)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
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
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 62)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 64)
        {
            spawnPoint = transform.GetChild(2).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(3).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            spawnPoint = transform.GetChild(4).transform;
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
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
