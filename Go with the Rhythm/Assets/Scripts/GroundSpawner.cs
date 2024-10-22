using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnData)
    {
        //What to spawn, where to spawn, what rotation to spawn (identity = no rotation)
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //Get spawnpoint = get child info on where to spawn, position
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        //Whether to spawn data/items on the tile
        if (spawnData)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i < 2)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
        }
    }
}
