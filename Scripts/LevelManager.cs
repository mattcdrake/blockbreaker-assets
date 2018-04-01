using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string nextLevel)
    {
        Debug.Log("Level load requested for " + nextLevel);
        Application.LoadLevel(nextLevel);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
