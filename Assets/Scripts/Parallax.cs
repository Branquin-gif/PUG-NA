using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEfx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //defines speed of parallax
        float distance = cam.transform.position.x * parallaxEfx;
        float movement = cam.transform.position.x * (1-parallaxEfx);

        //defines movement of parallax
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        //loops
        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
