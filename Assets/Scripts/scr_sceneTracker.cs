using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_sceneTracker : MonoBehaviour
{
    // This method is called when a new scene is loaded
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // This method is called when the object becomes inactive or is destroyed
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // This method is called when a scene is loaded
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Save the current scene to PlayerPrefs
        SaveSceneVisited(scene.name);
    }

    // Save the scene to PlayerPrefs
    private void SaveSceneVisited(string sceneName)
    {
        // Check if the scene has not been visited yet
        if (!PlayerPrefs.HasKey(sceneName))
        {
            // Mark the scene as visited by setting a PlayerPrefs key with the scene name
            PlayerPrefs.SetInt(sceneName, 1);
            PlayerPrefs.Save();
        }
    }

    // Check if a scene has been visited
    public bool IsSceneVisited(string sceneName)
    {
        return PlayerPrefs.HasKey(sceneName);
    }
}
