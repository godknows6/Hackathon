using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Disp4 : MonoBehaviour {
	public GameObject plane4;
	// Use this for initialization
	void Start ()
	{
		plane4 = GameObject.Find ("Cube");
		plane4.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Info_Click()
	{
		if (plane4.activeSelf) {
			plane4.SetActive (false);
		}
		else
		{
			plane4.SetActive (true);
		}
	}
}
