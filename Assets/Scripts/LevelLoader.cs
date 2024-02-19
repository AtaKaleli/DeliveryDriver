using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Animator transition;

    public static LevelLoader instance;
    private void Awake()
    {
        instance = this;
    }

    


    public void LoadNextLevel()
    {
        int level = (SceneManager.GetActiveScene().buildIndex + 1) % 3;
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(level));
    }

    public void MoveMenu()
    {
        Time.timeScale = 1f;
        StartCoroutine(GoMenuLevelSelection());
    }

    public void restartAnimation()
    {
        Time.timeScale = 1f;
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetBool("TransitionOn",true);
        yield return new WaitForSeconds(1.5f);
        transition.SetBool("TransitionOn", false);
        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator GoMenuLevelSelection()
    {
        transition.SetBool("TransitionOn", true);
        yield return new WaitForSeconds(1.5f);
        transition.SetBool("TransitionOn", false);
        SceneManager.LoadScene("OpeningScene");
    }

   

}
