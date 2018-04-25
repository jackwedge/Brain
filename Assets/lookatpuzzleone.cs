using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatpuzzleone : MonoBehaviour {


	public Animator animationcontroller; 



	public 	AudioClip lookatthefuckingpuzzleclip;
	public AudioSource lookatthefuckingpuzzlesource;

	bool look = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown (){




		if (Input.GetMouseButton (0)) {


			if (!lookatthefuckingpuzzlesource.isPlaying) {
				lookatthefuckingpuzzlesource.PlayOneShot (lookatthefuckingpuzzleclip);
			}




			look =true;
			animationcontroller.Play ("pointatme");


			Debug.Log ("areyouworkingtoday?");
		} 

		//
		else {
			animationcontroller.Play ("lookatthisfuckingpuzzlern");

		}
	}
}
