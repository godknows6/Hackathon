using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Disp3 : MonoBehaviour {
	public GameObject plane3, text3;
	// Use this for initialization
	void Start ()
	{
		plane3 = GameObject.Find ("Info_Plane3");
		text3 = GameObject.Find ("Info Text3");
		plane3.SetActive (false);
		text3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Info_Click()
	{
		if (text3.activeSelf) {
			plane3.SetActive (false);
			text3.SetActive (false);
		}
		else
		{
			plane3.SetActive (true);
			text3.SetActive (true);
		}
	}
}
