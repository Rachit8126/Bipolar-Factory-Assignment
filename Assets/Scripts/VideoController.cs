using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{

    [SerializeField] private VideoPlayer videoPlayer;
    private bool isVideoPlaying = false;

private void Start() {
    Cursor.lockState = CursorLockMode.None;
}

// function to play video if it is not playing
public void PlayVideo()
{
    if(!isVideoPlaying){
        videoPlayer.Play();
        isVideoPlaying = true;
    }
}

// function to pause video if it is playing
public void PauseVideo()
{
    if(isVideoPlaying)
    {
        videoPlayer.Pause();
        isVideoPlaying = false;
    }
}

// function to return to city scene
public void ExitScene()
{
    SceneManager.LoadScene(0);
}
}
