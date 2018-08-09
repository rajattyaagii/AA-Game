using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackandExit : MonoBehaviour
{

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        int buildIndex = currentScene.buildIndex;

        if (Input.GetKey(KeyCode.Escape))
        {



            if (sceneName == "Game Over")
            {

                Application.LoadLevelAsync(0);



            }

            else if (sceneName == "Menu")
            {
                Application.Quit();
            }
        }

    }
}
