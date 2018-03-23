using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video_PlayBack3 : MonoBehaviour {
	public VideoPlayer video3;
	// Use this for initialization
	void Start ()
	{
		video3 = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void video_Click()
	{
		if (video3.isPlaying) {
			video3.Pause ();
			video3.GetTargetAudioSource (0).Pause ();
		}
		else
		{
			video3.Play ();
			video3.GetTargetAudioSource (0).UnPause ();
		}
	}
}
