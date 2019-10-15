using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScript : MonoBehaviour {

    

    // Update is called once per frame
    public void ChangeToScene () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void Quit()
    {
        Application.Quit();
    }

}
