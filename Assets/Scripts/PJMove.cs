using UnityEngine;

public class PJMove : MonoBehaviour{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float xVelocity = 5.0f;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxisRaw("Horizontal");
        
        rb.linearVelocityX = mX * xVelocity;
    }
}
