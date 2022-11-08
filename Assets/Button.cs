using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button : MonoBehaviour
{
    public void loadGameWorld()
    {

        //passing information to next scene
        //DontDestroyOnLoad(player);
        SceneManager.LoadScene("OverWorld");

    }
}
