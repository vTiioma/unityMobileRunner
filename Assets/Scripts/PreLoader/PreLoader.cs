using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PreLoader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadLevelAsync(2));
        this.gameObject.SetActive(false);
    }
    /// <summary>
    /// Function that calls the coroutine that runs the scene loader
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void LoadLevel(int sceneIndex)
    {

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