using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Disp2 : MonoBehaviour {
	public GameObject plane2, text2;
	// Use this for initialization
	void Start ()
	{
		plane2 = GameObject.Find ("Info_Plane2");
		text2 = GameObject.Find ("Info Text2");
		plane2.SetActive (false);
		text2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Info_Click()
	{
		if (text2.activeSelf) {
			plane2.SetActive (false);
			text2.SetActive (false);
		}
		else
		{
			plane2.SetActive (true);
			text2.SetActive (true);
		}
	}
}
