using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Disp1 : MonoBehaviour {
	public GameObject plane1, text1;
	// Use this for initialization
	void Start ()
	{
		plane1 = GameObject.Find ("Info_Plane1");
		text1 = GameObject.Find ("Info Text1");
		plane1.SetActive (false);
		text1.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Info_Click()
	{
		if (text1.activeSelf) {
			plane1.SetActive (false);
			text1.SetActive (false);
		}
		else
		{
			plane1.SetActive (true);
			text1.SetActive (true);
		}
	}
}
