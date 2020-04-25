using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float TransitionTime = 1f;
    public int LevelIndex;

    public void LoadLevel()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            PauseMenu.p = false;
        }
        StartCoroutine(LoadLevelQ(LevelIndex));
    }

    IEnumerator LoadLevelQ(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(TransitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
