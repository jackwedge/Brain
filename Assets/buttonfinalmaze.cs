using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonfinalmaze : MonoBehaviour {

	public Image helpTextBox;
	bool hide = true;
	public GameObject finalmazecamera;
	public Sprite switchperspective;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if (finalmazecamera.GetComponent<finalmazecamera>().bigbrainactive == true)
		{
			helpTextBox.GetComponent<Image>().sprite = switchperspective;
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

		if (Input.GetKey (KeyCode.Space)) {
			helpTextBox.gameObject.SetActive (false);

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






