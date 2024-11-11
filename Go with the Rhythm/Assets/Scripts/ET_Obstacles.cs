using UnityEngine;

public class ET_Obstacles : MonoBehaviour
{
    ET_GroundSpawner groundSpawner;

    //Obstacles
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstacleChance = 0.2f;

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

    public void SpawnObstacle()
    {
        //Choose which obstacle to spawn
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 1f);

        if (random < tallObstacleChance)
        {
            obstacleToSpawn = tallObstaclePrefab;
        }

        //Choose random point to spawn obstacle
        int obstacleSpawnIndex = Random.Range(2, 10);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Spawn the obstacle at the position
        Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
    }
}
