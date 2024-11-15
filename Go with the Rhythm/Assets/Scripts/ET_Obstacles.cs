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
        int obstacleSpawnIndex = Random.Range(2, 10);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        //Predetermined Spawned obstacles
        if (CurrentNodeSpawn == 0)
        {
            spawnPoint = transform.GetChild(2).transform;

            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 1)
        {
            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 2)
        {
            spawnPoint = transform.GetChild(2).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(5).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 3)
        {
            spawnPoint = transform.GetChild(5).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 5)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(2).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 6)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(6).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(2).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            
            spawnPoint = transform.GetChild(5).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 7)
        {
            spawnPoint = transform.GetChild(9).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 8)
        {
            spawnPoint = transform.GetChild(9).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(5).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(6).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 9)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 10)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(9).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(2).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(8).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 11)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(9).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 15)
        {
            spawnPoint = transform.GetChild(3).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(9).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(4).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

            spawnPoint = transform.GetChild(10).transform;

            //Spawn the obstacle at the position
            Instantiate(ElectricObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (CurrentNodeSpawn == 16)
        {
            
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
