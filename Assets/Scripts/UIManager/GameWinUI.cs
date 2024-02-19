using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameWinUI : MonoBehaviour
{

    [SerializeField] private GameObject levelLoader;
    [SerializeField] private GameObject videoPlayer;
    [SerializeField] private VideoPlayer video;

    private void Awake()
    {
        StartCoroutine(VideoEndSkipTutorial());
    }


    public void OnClickSkipVideo()
    {
        videoPlayer.SetActive(false);
        levelLoader.SetActive(true);
        LevelLoader.instance.LoadNextLevel();
    }

    IEnumerator VideoEndSkipTutorial()
    {
        // Wait for the video to be prepared
        video.Prepare();

        // Wait until the video is prepared
        while (!video.isPrepared)
        {
            yield return null;
        }

        // Now that the video is prepared, get its length
        float videoLength = (float)video.frameCount / (float)video.frameRate;

        // Wait for the video to finish playing
        yield return new WaitForSeconds(videoLength);

        // Skip the video
        OnClickSkipVideo();
    }


}
