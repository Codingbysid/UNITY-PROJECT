using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        StartCoroutine(LoadSceneRoutine());
    }

    IEnumerator LoadSceneRoutine()
    {
        for (int i = 0; i < 15; i++)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

            // Wait until the scene is fully loaded
            while (!asyncOperation.isDone)
            {
                yield return null;
            }
        }
    }
}
// In the Start method, we start a coroutine called LoadSceneRoutine. This coroutine loads the specified scene 15 times using a for loop. We use SceneManager.LoadSceneAsync to load the scene asynchronously, which allows the program to continue running while the scene is loading. We then wait until the scene is fully loaded by checking the isDone property of the AsyncOperation object. Once the scene is loaded, we repeat the process until the loop is complete. This script can be attached to an empty GameObject in the scene, and the sceneName variable can be set in the Inspector to specify the scene to load.// In this script, we first define two constants: maxRuns and runCountKey. The maxRuns constant determines the maximum number of times the program should run before exiting. The runCountKey constant is used as the key to store and retrieve the run count from PlayerPrefs.
