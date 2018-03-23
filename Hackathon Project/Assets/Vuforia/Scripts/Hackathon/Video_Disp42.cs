using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_Disp42 : MonoBehaviour {
	public GameObject video_plane42,video_btn42;
	// Use this for initialization
	void Start ()
	{
		video_plane42 = GameObject.Find ("Video_Plane4-2");
		video_btn42 = GameObject.Find ("Play2 Button4");
		video_plane42.SetActive (false);
		video_btn42.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Video_Click()
	{
		if (video_plane42.activeSelf)
		{
			video_plane42.SetActive (false);
			video_btn42.SetActive (false);
		}
		else
		{
			video_plane42.SetActive (true);
			video_btn42.SetActive (true);
		}
	}
}
