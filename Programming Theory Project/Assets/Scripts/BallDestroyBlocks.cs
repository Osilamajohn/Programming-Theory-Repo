using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyBlocks : BallController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    private void OnCollisionEnter(Collision collision)
    {
            ball.velocity = new Vector2(ball.velocity.x, -ball.velocity.y);
            Debug.Log("cube direction inverted");
            gameObject.SetActive(false);
            Debug.Log("cube destroyed");
           
        
    }

}

