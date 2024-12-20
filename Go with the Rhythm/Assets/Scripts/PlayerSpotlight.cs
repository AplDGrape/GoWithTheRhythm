using UnityEngine;

public class PlayerSpotlight : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;

    //Speed of Player
    public float speed = 11.66666666f;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.y = 9;

        //Linear Interpolate Light Movement
        transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
    }
}
