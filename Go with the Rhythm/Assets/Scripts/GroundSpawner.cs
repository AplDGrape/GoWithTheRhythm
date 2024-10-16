using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        //What to spawn, where to spawn, what rotation to spawn (identity = no rotation)
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //Get spawnpoint = get child info on where to spawn, position
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
    }
}
