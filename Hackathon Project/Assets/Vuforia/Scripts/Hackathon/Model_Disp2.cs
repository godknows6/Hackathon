using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Disp2 : MonoBehaviour {
	public GameObject model2;
	// Use this for initialization
	void Start ()
	{
		model2 = GameObject.Find ("Model2");
		model2.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Model_Click()
	{
		if (model2.activeSelf) {
			model2.SetActive (false);
		}
		else
		{
			model2.SetActive (true);
		}
	}
}