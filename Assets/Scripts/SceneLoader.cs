using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentScene = 0;

    public void loadNextScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene + 1);

        currentScene = SceneManager.GetActiveScene().buildIndex;
    }
}
