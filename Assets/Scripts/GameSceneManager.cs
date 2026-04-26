using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void ReloadLeel()
    {
        StartCoroutine(LoadSceneWithDelay());

    }
    IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(2f);
             int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

