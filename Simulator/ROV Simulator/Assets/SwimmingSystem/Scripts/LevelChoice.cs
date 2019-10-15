using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoice : MonoBehaviour {

    public static bool isQR1 = false;
    public static bool isQR2 = false;
    public static bool isMR = false;

    public void ChangeToQR1()
    {
        isQR1 = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeToQR2()
    {
        isQR2 = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeToMR()
    {
        isMR = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public bool GetQR1()
    {
        return isQR1;
    }
    public bool GetQR2()
    {
        return isQR2;
    }
    public bool GetMR()
    {
        return isMR;
    }
}
