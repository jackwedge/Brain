using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonfunctionscene3 : MonoBehaviour {

	public Image helpTextBox;
	bool hide = true;
	public GameObject camerascene3;
	public Sprite clickontongue;
	public Sprite arrowkeysthroughintestine;
	public Sprite playthepianohint;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (camerascene3.GetComponent<Transform>().position == camerascene3.GetComponent<cameracontrollerpuzzle3>().standontongueposition)
		{
			helpTextBox.GetComponent<Image>().sprite = clickontongue;
		}


		if (camerascene3.GetComponent<Transform>().position == camerascene3.GetComponent<cameracontrollerpuzzle3>().intenstinesposition)
		{
			helpTextBox.GetComponent<Image>().sprite = arrowkeysthroughintestine;
		}



		if (camerascene3.GetComponent<Transform>().position == camerascene3.GetComponent<cameracontrollerpuzzle3>().pianopuzzleposition)
		{
			helpTextBox.GetComponent<Image>().sprite = playthepianohint;
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
