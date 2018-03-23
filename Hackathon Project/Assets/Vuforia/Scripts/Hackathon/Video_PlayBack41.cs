using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video_PlayBack41 : MonoBehaviour {
	public VideoPlayer video41;
	// Use this for initialization
	void Start ()
	{
		video41 = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void video_Click()
	{
		if (video41.isPlaying) {
			video41.Pause ();
			video41.GetTargetAudioSource (0).Pause ();
		}
		else
		{
			video41.Play ();
			video41.GetTargetAudioSource (0).UnPause ();
		}
	}
}
