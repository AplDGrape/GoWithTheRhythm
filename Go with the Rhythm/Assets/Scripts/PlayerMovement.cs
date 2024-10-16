using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    //Speed of Player
    public float speed = 5;
    public Rigidbody rb;
    
    //Makes horizontal move faster than speed
    public float horizontalMultiplier = 1.5f;
    
    float horizontalInput;

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
}
