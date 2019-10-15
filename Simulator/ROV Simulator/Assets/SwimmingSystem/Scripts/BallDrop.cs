using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallDrop : MonoBehaviour {

    public Transform cube_transform;
    public Transform ball_transform;
    public Rigidbody ball_rigidbody;

    // Use this for initialization
    void Start () {
        ball_rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DropsBall();
        }
	}

    void DropsBall()
    {
        Vector3 new_ball_position = cube_transform.position + new Vector3(-5, 2, 0);
        ball_transform.position = new_ball_position;
        ball_rigidbody.useGravity = true;
    }

}
