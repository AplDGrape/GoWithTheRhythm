using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner> ();
        SpawnObstacle();
    }

    void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        //Choose random point to spawn obstacle
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Spawn the obstacle at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

}
