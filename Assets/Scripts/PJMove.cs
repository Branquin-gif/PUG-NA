using UnityEngine;

public class PJMove : MonoBehaviour{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float xVelocity = 5.0f;
    float jumpForce = 10.0f;
    public GameObject cam;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * xVelocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocityY = jumpForce;
        }
    }
}
