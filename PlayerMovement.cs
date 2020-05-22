using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000;
    public float rightForce = 500;
    public float leftForce = -500;
    public float upForce = 500;
    public float downForce = -500;
    public float constantUp = 250;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, constantUp * Time.deltaTime, 0);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(leftForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, downForce * Time.deltaTime, 0);
        }
    }



}