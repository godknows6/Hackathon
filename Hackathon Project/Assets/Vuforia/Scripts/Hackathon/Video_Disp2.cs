using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Disp2 : MonoBehaviour {
	public GameObject video_plane2,video_btn2;
	// Use this for initialization
	void Start ()
	{
		video_plane2 = GameObject.Find ("Video_Plane2");
		video_btn2 = GameObject.Find ("Play Button2");
		video_plane2.SetActive (false);
		video_btn2.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Video_Click()
	{
		if (video_plane2.activeSelf)
		{
			video_plane2.SetActive (false);
			video_btn2.SetActive (false);
		}
		else
		{
			video_plane2.SetActive (true);
			video_btn2.SetActive (true);
		}
	}
}

