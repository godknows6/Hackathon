using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video_PlayBack42 : MonoBehaviour {
	public VideoPlayer video42;
	// Use this for initialization
	void Start ()
	{
		video42 = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void video_Click()
	{
		if (video42.isPlaying) {
			video42.Pause ();
			video42.GetTargetAudioSource (0).Pause ();
		}
		else
		{
			video42.Play ();
			video42.GetTargetAudioSource (0).UnPause ();
		}
	}
}
