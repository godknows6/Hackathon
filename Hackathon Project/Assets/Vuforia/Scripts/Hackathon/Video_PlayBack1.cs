using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video_PlayBack1 : MonoBehaviour {
	public VideoPlayer video;
	// Use this for initialization
	void Start ()
	{
		video = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void video_Click()
	{
		if (video.isPlaying) {
			video.Pause ();
			video.GetTargetAudioSource (0).Pause ();
		}
		else
		{
			video.Play ();
			video.GetTargetAudioSource (0).UnPause ();
		}
	}
}
