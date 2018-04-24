using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {

	//public AudioSource hellotreesource;


		public Animator anim;
		public SpriteRenderer SR;
		bool hatch = false;

	public AudioClip hatchsoundclip;
	public AudioSource hatchsoundsource;



	// Use this for initialization
	void Start () {
		anim = transform.GetComponent<Animator>();
//		print ("set animator");

		
	}
	
	// Update is called once per frame

	void OnMouseDown(){


		Debug.Log("click");
		if (MAINCAMERA.Me.state == 1  && Input.GetMouseButtonDown (0)) {
			hatch = true;

			hatchsoundsource.clip = hatchsoundclip;
			hatchsoundsource.Play ();
			MAINCAMERA.Me.state = 2;




		}




	}
		


	void Update () {

	


//		Debug.Log (MAINCAMERA.Me.state);
		anim.SetBool ("hatch", hatch);
	}
}
