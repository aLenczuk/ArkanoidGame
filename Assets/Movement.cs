using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
	}
}
