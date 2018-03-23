using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Disp3 : MonoBehaviour {
	public GameObject video_plane3,video_btn3;
	// Use this for initialization
	void Start ()
	{
		video_plane3 = GameObject.Find ("Video_Plane3");
		video_btn3 = GameObject.Find ("Play Button3");
		video_plane3.SetActive (false);
		video_btn3.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Video_Click()
	{
		if (video_plane3.activeSelf)
		{
			video_plane3.SetActive (false);
			video_btn3.SetActive (false);
		}
		else
		{
			video_plane3.SetActive (true);
			video_btn3.SetActive (true);
		}
	}
}

