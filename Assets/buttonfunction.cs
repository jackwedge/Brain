using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonfunction : MonoBehaviour {


	public Sprite fieldhelp;
	public Sprite brainhelp;
	public Sprite treehelp;
	//declare new sprites here
	public Image helpTextBox;
	public GameObject cameraGO;

	bool hide = true;

	// Use this for initialization
	void Start() {
		//function hides and shows hint button. Check bottom of script to edit. 
		this.GetComponent<Button>().onClick.AddListener(onButtonPress);

	}

	// Update is called once per frame
	void Update () {
		if (cameraGO.GetComponent<Transform>().position == cameraGO.GetComponent<MAINCAMERA>().fieldposition)
		{
			helpTextBox.GetComponent<Image>().sprite = fieldhelp;
		}
		else if (cameraGO.GetComponent<Transform>().position == cameraGO.GetComponent<MAINCAMERA>().treeposition)
		{
			helpTextBox.GetComponent<Image>().sprite = treehelp;
		}
		else if (cameraGO.GetComponent<Transform>().position == cameraGO.GetComponent<MAINCAMERA>().welcome2brainposition)
		{
			helpTextBox.GetComponent<Image>().sprite = brainhelp;
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
		else if (hide == false)
		{
			helpTextBox.gameObject.SetActive(false);
			hide = true;
			Debug.Log("not here");
		}

	}

}

