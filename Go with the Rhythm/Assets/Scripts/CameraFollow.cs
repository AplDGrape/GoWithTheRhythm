using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //position of camera - position of player
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Follows player indefinitely
        //transform.position = player.position + offset;
        //Follow player like a endless runner type game
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        targetPos.y = 8;
        transform.position = targetPos;
    }
}
