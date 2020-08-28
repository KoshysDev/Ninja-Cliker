using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenuScipts
{
    public class LevelLoaderScript : MonoBehaviour
    {
        public Animator transition;
        public float transitionTime = 1f;
        public int levelIndex;
        private static readonly int Start = Animator.StringToHash("Start");

        // ReSharper disable once UnusedMember.Global
        public void LoadLevel()
        {
            LoadNextLevel();
        }

        public void LoadNextLevel()
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                PauseMenu.P = false;
            }
            StartCoroutine(LoadLevelQ(levelIndex));
        }

        private IEnumerator LoadLevelQ(int levelId)
        {
            transition.SetTrigger(Start);

            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(levelId);
        }
    }
}
