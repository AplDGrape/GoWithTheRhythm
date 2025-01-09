using UnityEngine;

public class ET_GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    //Obstacle spawn value
    int i = 0;
    //Wall & Floor spawn value
    int j = 0;

    public void SpawnTile(bool spawnData)
    {
        //What to spawn, where to spawn, what rotation to spawn (identity = no rotation)
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //Get spawnpoint = get child info on where to spawn, position
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        //Whether to spawn data/items on the tile
        if (spawnData)
        {
            StartCoroutine(temp.GetComponent<ET_Obstacles>().SpawnObstacle(i));

            i++;
        }

        //Spawn the floors
        temp.GetComponent<ET_Floor>().SpawnFloor(j);

        //Spawn the walls
        temp.GetComponent<ET_Wall>().SpawnWall(j);

        j++;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int k = 0; k < 10; k++)
        {
            if (k < 10)
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
