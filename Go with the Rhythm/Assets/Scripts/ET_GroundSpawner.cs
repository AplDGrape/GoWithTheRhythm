using UnityEngine;

public class ET_GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    int i = 0;
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
            temp.GetComponent<ET_Obstacles>().SpawnObstacle(i);

            i++;
        }

        //Spawn the floors
        temp.GetComponent<ET_Floor>().SpawnFloor(j);

        j++;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i < 10)
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
