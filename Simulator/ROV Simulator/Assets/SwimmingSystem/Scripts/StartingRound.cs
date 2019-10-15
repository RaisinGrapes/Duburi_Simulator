using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingRound : MonoBehaviour {

    public LevelChoice level;
    // starting positions of Qualification Arena 1, 2, and the Main Arena respectively
    public Vector3 QA1 = new Vector3(78.3f, 28.23937f, -244.08f);  
    public Vector3 QA2 = new Vector3(-91.2f, 28.23937f, -244.08f);
    public Vector3 MA = new Vector3(119.9797f, 28.23937f, 22.4f);

    // Use this for initialization
    void Start () {
		if (level.GetMR())  // if Main Arena among the 3 rounds was selected then GetMR() returns true 
        {
            transform.position = MA;
        }
        if (level.GetQR1())
        {
            transform.position = QA1;
            transform.Rotate(0, 90, 0);
        }
        if (level.GetQR2())
        {
            transform.position = QA2;
            transform.Rotate(0, 90, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
        Reset();       
	}

    // if 'R' is pressed, the scene reloads. In other words, we start from the starting position again
    private void Reset()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
