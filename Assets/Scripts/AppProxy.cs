using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppProxy : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        App.Instance.LoadScene(sceneName);
    }

    public void SaveObjectsFromARScene()
    {
        App.Instance.SaveObjectsFromARScene();
        App.Instance.LoadScene("Overzicht");
    }

    public void LoadObjectsToARScene()
    {
        App.Instance.LoadObjectsToARScene();
    }
}
