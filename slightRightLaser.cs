using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slightRightLaser : MonoBehaviour
{

    private LineRenderer lr;
    public Rigidbody rb;
    public float upForce = 100;
    public float backForce = 100;
    public float rightForce = 100;
    public float leftForce = -100;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);
                rb.AddForce(0, 0, backForce);
                rb.AddForce(0, upForce * Time.deltaTime, 0);
                rb.AddForce(rightForce, 0, 0);
                rb.AddForce(leftForce, 0, 0);
            }
        }
        else lr.SetPosition(1, transform.forward);
    }
}
