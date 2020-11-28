using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitToMenu : MonoBehaviour
{
    public string levelToLoad;
    public void ExitToMenuFromGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
