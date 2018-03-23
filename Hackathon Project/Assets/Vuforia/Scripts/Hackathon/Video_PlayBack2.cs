using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video_PlayBack2 : MonoBehaviour {
	public VideoPlayer video2;
	// Use this for initialization
	void Start ()
	{
		video2 = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void video_Click()
	{
		if (video2.isPlaying) {
			video2.Pause ();
			video2.GetTargetAudioSource (0).Pause ();
		}
		else
		{
			video2.Play ();
			video2.GetTargetAudioSource (0).UnPause ();
		}
	}
}
