using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Disp1 : MonoBehaviour {
	public GameObject video_plane1,video_btn;
	// Use this for initialization
	void Start ()
	{
		video_plane1 = GameObject.Find ("Video_Plane1");
		video_btn = GameObject.Find ("Button4");
		video_plane1.SetActive (false);
		video_btn.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Video_Click()
	{
		if (video_plane1.activeSelf)
		{
			video_plane1.SetActive (false);
			video_btn.SetActive (false);
		}
		else
		{
			video_plane1.SetActive (true);
			video_btn.SetActive (true);
		}
	}
}

