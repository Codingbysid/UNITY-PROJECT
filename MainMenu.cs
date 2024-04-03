using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private const int maxRuns = 15;
    private const string runCountKey = "RunCount";

    void Start()
    {
        // Increment run count
        int runCount = PlayerPrefs.GetInt(runCountKey, 0);
        runCount++;
        PlayerPrefs.SetInt(runCountKey, runCount);

        // Check if the program should run again
        if (runCount <= maxRuns)
        {
            // Load the scene
            SceneLoader sceneLoader = FindObjectOfType<SceneLoader>();
            if (sceneLoader != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.LogError("SceneLoader not found!");
            }
        }
        else
        {
            // Reset run count
            PlayerPrefs.SetInt(runCountKey, 0);

            // Optionally, display a message or perform other actions
            Debug.Log("Program has run " + maxRuns + " times. Exiting...");
        }
    }
}
// In this script, we first define two constants: maxRuns and runCountKey. The maxRuns constant determines the maximum number of times the program should run before exiting. The runCountKey constant is used as the key to store and retrieve the run count from PlayerPrefs.