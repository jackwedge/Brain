using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonfunctionscene2 : MonoBehaviour {


	public Image helpTextBox;
	bool hide = true;
	public GameObject camerascene2;
	public Sprite eyeballhelp;



	// Use this for initialization
	void Start () {
		//function hides and shows hint button. Check bottom of script to edit. 
	this.GetComponent<Button>().onClick.AddListener(onButtonPress);


	}
	
	// Update is called once per frame
	void Update () {
		if (camerascene2.GetComponent<Transform>().position == camerascene2.GetComponent<puzzle2camera>().Puzzle2position)
		{
			helpTextBox.GetComponent<Image>().sprite = eyeballhelp;
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
		Debug.Log ("buttonworking?");
		if (hide == true)
		{
			helpTextBox.gameObject.SetActive(true);
			hide = false;
			Debug.Log("here");
		}









	}

}

