using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class walkingintotrap : MonoBehaviour {
	public SpriteRenderer walkintotrapSpriteRenderer;
	public Sprite [] mysprites;
	public GameObject forklift;

	public GameObject bubblemanisdyin;

	public MAINCAMERA cameraman;

	public AudioSource walkinginfieldsource;
	public AudioClip walkinginfieldsound;

	public AudioSource ouchsoundsource;
	public AudioClip ouchsoundclip;



	float timer;

	float waittime =0.1f;

	int interval= 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (cameraman.state == 4) {
			
		//
		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (MAINCAMERA.Me.state == 4 && Input.GetKey (KeyCode.RightArrow) && timer <= 0) {
			walkintotrapSpriteRenderer.sprite = mysprites [interval];
			interval++;


			if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Play ();


			}

			if (interval >= mysprites.Length) {
				interval = mysprites.Length - 1;
			}


				if (interval == 44) {

					Debug.Log ("areuworking");
					Destroy(bubblemanisdyin);
					forklift.gameObject.SetActive (true);
					ouchsoundsource.clip = ouchsoundclip;
					ouchsoundsource.Play ();



					MAINCAMERA.Me.state = 5;

				}


			timer += waittime;



		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			if (walkinginfieldsource.isPlaying) {


				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();

			}
		}







		if (MAINCAMERA.Me.state == 4 && Input.GetKey (KeyCode.LeftArrow) && timer <= 0) {
			walkintotrapSpriteRenderer.sprite = mysprites [interval];

			interval--;

			if (!walkinginfieldsource.isPlaying) { // == means "is equal to?"

				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Play ();


			}

			if (interval <= 0) {
				interval = 0;
			}


			timer += waittime;

		}


		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			if (walkinginfieldsource.isPlaying) {


				walkinginfieldsource.clip = walkinginfieldsound;
				walkinginfieldsource.Stop ();

			}
		}

	
	}
}
}
