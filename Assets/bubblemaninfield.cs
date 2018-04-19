using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class bubblemaninfield : MonoBehaviour {

	public GameObject forklift;
	public Animator anim;
	public SpriteRenderer SR;
	bool walking = false;
	public AudioSource walkinginfieldsource;
	public AudioClip walkinginfieldsound;

	public AudioSource ouchsoundsource;
	public AudioClip ouchsoundclip;


	public MAINCAMERA cameraman;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		SR = GetComponent<SpriteRenderer> ();
		//AudioSource = GetComponent < AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {


			

		if (cameraman.state == 3) {

			//bool walking = false;
			if (Input.GetKey (KeyCode.RightArrow)) {

				if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

					walkinginfieldsource.clip = walkinginfieldsound;
					walkinginfieldsource.Play ();


				}

				Vector3 pos = transform.position;
				pos.x += 0.04f;
				transform.position = pos;
				walking = true;
				//SR.flipX = true;
				transform.eulerAngles = new Vector3 (0, 0, -90);
			}

			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();


			}



			if (Input.GetKey (KeyCode.LeftArrow)) {

				if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

					walkinginfieldsource.clip = walkinginfieldsound;
					walkinginfieldsource.Play ();


				}
				Vector3 pos = transform.position;
				pos.x += -0.04f;
				transform.position = pos;
				walking = true;
				//SR.flipX = false;
				transform.eulerAngles = new Vector3 (0, 0, 90);
			}


			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();


			}

			if (Input.GetKey (KeyCode.UpArrow)) {

				if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

					walkinginfieldsource.clip = walkinginfieldsound;
					walkinginfieldsource.Play ();


				}

				Vector3 pos = transform.position;
				pos.y += +0.04f;
				transform.position = pos;
				walking = true;
				transform.eulerAngles = new Vector3 (0, 0, 0);
				//	transform.position.x += 1;


			}

			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();


			}



			if (Input.GetKey (KeyCode.DownArrow)) {

				if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

					walkinginfieldsource.clip = walkinginfieldsound;
					walkinginfieldsource.Play ();


				}

				Vector3 pos = transform.position;
				pos.y += -0.04f;
				transform.position = pos;
				walking = true;
				transform.eulerAngles = new Vector3 (0, 0, 180);

			}

			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();


			}



			if (!Input.anyKey) {
				walking = false;
			}


			//		if Vector3 pos >
			//


			anim.SetBool ("walking", walking);

			
		}

		if (cameraman.state != 3) {
			walkinginfieldsource.clip = walkinginfieldsound;
			walkinginfieldsource.Stop ();
		}


//		if Vector3 pos >
//
	

		anim.SetBool ("walking", walking);


		
	}
}







	


	
	





