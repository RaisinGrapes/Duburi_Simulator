using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrop2 : MonoBehaviour {

    public MeshRenderer Ball_MR;
    public Rigidbody Ball_RB;

	// Use this for initialization
	void Start () {
        Ball_MR.enabled = false;
        Ball_RB.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            DropsBall();
        }

	}

    void DropsBall()
    {
        Ball_MR.enabled = true;
        Ball_RB.useGravity = true;
    }

}
