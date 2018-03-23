using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Disp1 : MonoBehaviour {
	public GameObject model1;
	// Use this for initialization
	void Start ()
	{
		model1 = GameObject.Find ("Model1");
		model1.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Model_Click()
	{
		if (model1.activeSelf) {
			model1.SetActive (false);
		}
		else
		{
			model1.SetActive (true);
		}
	}
}