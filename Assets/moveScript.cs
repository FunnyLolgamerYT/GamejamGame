using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float moveSpeed = 1;
    
    public float jump = 5;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jump , ForceMode2D.Impulse);
        }

    }
}
