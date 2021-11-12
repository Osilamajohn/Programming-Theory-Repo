using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRb;
    public Rigidbody ball;
    // Start is called before the first frame update
    private void Start()
    {
        ballRb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        float changeDirection = Random.Range(0, 2);
        if (collision.collider.tag == "Paddle")
        {
             if (changeDirection < -1)
            {
              ballRb.AddForce(new Vector2(20, -15));
            }
            else
            {
              ballRb.AddForce(new Vector2(-20, 15));
            }
            Debug.Log("Touch down");
        }
       
    }

}
