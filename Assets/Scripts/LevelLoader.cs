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
        StartCoroutine(LoadLevel(level));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetBool("TransitionOn",true);
        yield return new WaitForSeconds(1.5f);
        transition.SetBool("TransitionOn", false);
        SceneManager.LoadScene(levelIndex);
    }


}
