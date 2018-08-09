using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void Level1()
    {
        Application.LoadLevelAsync(1);
    }
    public void Level2()
    {
        Application.LoadLevelAsync(2);
    }
    public void Level3()
    {
        Application.LoadLevelAsync(3);
    }

    public void closeButton()
    {
        Application.Quit();
    }

    public void restartButton()
    {
        Application.LoadLevelAsync(0);
    }


}