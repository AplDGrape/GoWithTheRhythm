using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    //Speed of Player
    public float speed = 5;
    [SerializeField] public Rigidbody rb;
    
    //Makes horizontal move faster than speed
    [SerializeField] public float horizontalMultiplier = 1.5f;
    
    float horizontalInput;

    [SerializeField] float jumpForce = 300f;
    [SerializeField] LayerMask groundMask;

    void FixedUpdate()
    {
        if (!alive) return;

        //variable = direction * speed * time
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //movement for left and right
        Vector3 horizontalMove = -(transform.right) * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        //move position to a certain position
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        //Get key inputs for "left" and "right"
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (transform.position.y < -5)
        {
            Death();
        }
    }

    public void Death()
    {
        alive = false;

        //Restart
        Invoke("Restart", 1);
    }

    void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Jump()
    {
        //Check if grounded
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        //If grounded, make a jump
        rb.AddForce(Vector3.up * jumpForce);
    }
}
