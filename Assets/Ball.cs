using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddlee paddle1;
    Vector2 paddleToBallVector;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    [SerializeField] bool hasStarted = false;
    [SerializeField] Rigidbody2D rb;


    // Use this for initialization
    void Start () {


        paddleToBallVector = transform.position - paddle1.transform.position;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;

	}
	
	// Update is called once per frame
	void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LanuchToPaddle();
        }
    }
   

    private void LanuchToPaddle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            rb.simulated = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
