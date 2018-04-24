using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonfunctionoutskirts : MonoBehaviour {

	public Image helpTextBox;
	bool hide = true;
	public GameObject cameracontrolleroutskirts;
	public Sprite switchperp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (cameracontrolleroutskirts.GetComponent<Transform>().position == cameracontrolleroutskirts.GetComponent<cameracontrolleroutskirts>().colorbrainposition)
		{
			helpTextBox.GetComponent<Image>().sprite = switchperp;
		}
		

		if(	Input.GetMouseButtonDown (0)) { 


			helpTextBox.gameObject.SetActive(false);
			hide = true;
			Debug.Log("not here");
		}


		if (Input.GetKey (KeyCode.RightArrow)) {



			helpTextBox.gameObject.SetActive(false);
			hide = true;


		}

		if (Input.GetKey (KeyCode.LeftArrow)) {


			helpTextBox.gameObject.SetActive(false);

			hide = true;


		}


		if (Input.GetKey (KeyCode.UpArrow)) {

			helpTextBox.gameObject.SetActive(false);

			hide = true;


		}


		if (Input.GetKey (KeyCode.DownArrow)) {

			helpTextBox.gameObject.SetActive(false);

			hide = true;


		}

	}


	public void onButtonPress()
	{
		Debug.Log ("press");
		if (hide == true)
		{
			helpTextBox.gameObject.SetActive(true);
			hide = false;
			Debug.Log("here");
		}


	}
}








