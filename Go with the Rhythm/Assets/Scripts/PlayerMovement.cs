using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static bool alive = true;

    //Speed of Player
    public float speed = 11.66666666f; //Speed = Distance * (BPM / 60) -> 5 * (140 / 60)
    [SerializeField] public Rigidbody rb;

    //Get animator
    public Animator animator;

    //Makes horizontal move faster than speed
    [SerializeField] public float horizontalMultiplier = 0.75f;
    //Makes vertical move faster than speed
    [SerializeField] public float verticalMultiplier = 0.75f;

    float horizontalInput;
    float verticalInput;

    [SerializeField] float jumpForce = 300f;
    [SerializeField] LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        //Starts the player to be alive
        alive = true;
    }

    void FixedUpdate()
    {
        if (!alive) return;

        //variable = direction * speed * time
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //
        //Vector3 forwardMovement = transform.forward * verticalInput * speed * Time.fixedDeltaTime * verticalMultiplier;
        //movement for left and right
        Vector3 horizontalMove = -(transform.right) * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        //move position to a certain position
        rb.MovePosition(rb.position + forwardMove /*+ forwardMovement*/ + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        //Get key inputs for "left" and "right"
        horizontalInput = Input.GetAxis("Horizontal");
        //Get key inputs for "up" and "down"
        verticalInput = Input.GetAxis("Vertical");

        //Check if grounded
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        if (isGrounded)
        {
            animator.SetBool("isJumping", false);
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

        }
        else
        {
            animator.SetBool("isJumping", true);
        }
        if (transform.position.y < -1.5)
        {
            Death();
        }
    }

    public void Death()
    {
        //Kill player mwahahaha
        alive = false;

        //Restart
        //Invoke("Restart", 1);
    }

    //void Restart()
    //{
    //    SceneManager.LoadScene("MainMenu");
    //}

    void Jump()
    {
        ////Check if grounded
        //float height = GetComponent<Collider>().bounds.size.y;
        //isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        //If grounded, make a jump
        rb.AddForce(Vector3.up * jumpForce);
    }
}
