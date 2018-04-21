using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypressedcontroller : MonoBehaviour {

	public AudioClip pianokeypressedsound;
	public AudioSource pianokeypressedsource;


//	public AudioSource brokenharmoniumsource;
//	public AudioClip brokenharmoniumclip;
//


	public keyboardcontroller mymanager;
	public int mykeynumber;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonUp (0)) {
			pianokeypressedsource.Stop(); 

		}



	}

	void OnMouseDown (){

		if (!pianokeypressedsource.isPlaying) {
			pianokeypressedsource.PlayOneShot (pianokeypressedsound);
		}


//	brokenharmoniumsource.clip = pianokeypressedsound;
//	brokenharmoniumsource.Play ();


		Debug.Log ("pianoplaying" + mykeynumber);
		mymanager.MousePressed (mykeynumber);
	}



}


	//void

