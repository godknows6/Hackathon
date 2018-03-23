using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Disp3 : MonoBehaviour {
	public GameObject model3;
	// Use this for initialization
	void Start ()
	{
		model3 = GameObject.Find ("Model3");
		model3.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Model_Click()
	{
		if (model3.activeSelf) {
			model3.SetActive (false);
		}
		else
		{
			model3.SetActive (true);
		}
	}
}