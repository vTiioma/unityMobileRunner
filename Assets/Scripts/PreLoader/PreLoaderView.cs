using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PreLoaderView : PreLoaderApp
{

    // Use this for initialization
    protected virtual void Start()
    {

        model.onLoad += OnLoad;
        Debug.Log("Press any button to load...");
    }

    protected virtual void OnLoad()
    {
        StartCoroutine(LoadLevelAsync(2));
    }

    /// <summary>
    /// Loads level asynchronously
    /// </summary>
    /// <param name="sceneIndex"></param>
    /// <returns></returns>
    IEnumerator LoadLevelAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
