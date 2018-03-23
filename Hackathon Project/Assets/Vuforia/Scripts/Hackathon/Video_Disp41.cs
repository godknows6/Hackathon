using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Disp41 : MonoBehaviour {
	public GameObject video_plane41,video_btn41;
	// Use this for initialization
	void Start ()
	{
		video_plane41 = GameObject.Find ("Video_Plane4-1");
		video_btn41 = GameObject.Find ("Play1 Button4");
		video_plane41.SetActive (false);
		video_btn41.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Video_Click()
	{
		if (video_plane41.activeSelf)
		{
			video_plane41.SetActive (false);
			video_btn41.SetActive (false);
		}
		else
		{
			video_plane41.SetActive (true);
			video_btn41.SetActive (true);
		}
	}
}

