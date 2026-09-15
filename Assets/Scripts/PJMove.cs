using JetBrains.Annotations;
using UnityEngine;

public class PJMove : MonoBehaviour
{
    float velocidade = 10.0f;
    public Rigidbody2D rb;
    Vector2 ForçaPulo;
    int PodePular = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ForçaPulo = new Vector2(0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * velocidade;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PodePular ++;
            rb.AddForce(ForçaPulo, ForceMode2D.Impulse);
        } 
        if (PodePular == 2)
        {
            ForçaPulo.y = 0f;
        }
        if (PodePular < 2)
        {
            ForçaPulo.y = 6f;
        }
    }
    private void OnCollisionEnter2D(Collision2D colission)
    {
        if (colission.gameObject.CompareTag("Ground"))
        {
            PodePular = 0;
        }
    }
}
