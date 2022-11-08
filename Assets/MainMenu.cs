using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Vector3 originPosition = new Vector3(0.5f, 0.5f, 0);
    public void StartGame(bool ifNewGame)
    {
        if (ifNewGame || !Data.Instance.saved)
        {
            Data.Instance.playerPosition = originPosition;
        }        
        SceneManager.LoadScene("OverWorld");
    }
}
