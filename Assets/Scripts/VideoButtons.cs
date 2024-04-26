using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer player;
  

    public void playVideo()
    {
        player.Play();
    }
    public void stopVideo()
    {
        player.Stop();
    }
}
