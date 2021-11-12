using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;
    public List<GameObject> blockList;
    private float paddleSpeed = 1000;
    private float paddleMove;
    private Rigidbody paddleRb;
    private Rigidbody ballRb;
    private float jumpSpeed = 1000;
    bool alreadyMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        blockList = new List<GameObject>();
        paddleRb = paddle.gameObject.GetComponent<Rigidbody>();
        ballRb = ball.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ButtonPressed(); // Abstraction OOP
        BallJump();
    }
    void ButtonPressed()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            paddleMove = Input.GetAxis("Horizontal") * paddleSpeed * Time.deltaTime;
             paddleRb.transform.Translate(Vector3.right * paddleMove);
            Debug.Log("Left key has been pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            paddleMove = Input.GetAxis("Horizontal") * -1 * paddleSpeed * Time.deltaTime;
            paddleRb.transform.Translate(Vector3.left * paddleMove);
            Debug.Log("Right key has been pressed");
        }
    }
    void BallJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballRb.AddForce(Vector3.up * jumpSpeed);
            Debug.Log("space has been pressed");
        }
    }
}
