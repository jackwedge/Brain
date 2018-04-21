using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblemancolormazecontroller : MonoBehaviour {

	public SpriteRenderer SR;
	public bool walking = false;
	public Animator anim;
	public Rigidbody2D rigidbody;


	public AudioClip bubblemaninmazeaudioclip;
	public AudioSource bubblemaninmazeaudiosource;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 speed = Vector2.zero;


		if (Input.GetKey (KeyCode.RightArrow)) {
			//	Vector3 pos = transform.position;
			//	pos.x += 0.08f;
			speed.x = +10f;


			if (!bubblemaninmazeaudiosource.isPlaying) {
				bubblemaninmazeaudiosource.PlayOneShot (bubblemaninmazeaudioclip);
			}



			//	transform.position = pos;
			//	walking = true;
			//	SR.flipX = false;
		}


		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			
			bubblemaninmazeaudiosource.Stop ();


		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			if (!bubblemaninmazeaudiosource.isPlaying) {
				bubblemaninmazeaudiosource.PlayOneShot (bubblemaninmazeaudioclip);
			}


			speed.x = -10f;
			//			Vector3 pos = transform.position;
			//			pos.x += -0.08f;
			//			transform.position = pos;
			//	walking = true;

			//	SR.flipX = true;
		}


		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			bubblemaninmazeaudiosource.Stop ();


		}

		if (Input.GetKey (KeyCode.UpArrow)) {

			if (!bubblemaninmazeaudiosource.isPlaying) {
				bubblemaninmazeaudiosource.PlayOneShot (bubblemaninmazeaudioclip);
			}



			speed.y = +10f;
			//			Vector3 pos = transform.position;
			//			pos.y += +0.08f;
			//			transform.position = pos;
			//		//	walking = true;

			//	transform.position.x += 1;


		}

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			bubblemaninmazeaudiosource.Stop ();


		}

		if (Input.GetKey (KeyCode.DownArrow)) {

			if (!bubblemaninmazeaudiosource.isPlaying) {
				bubblemaninmazeaudiosource.PlayOneShot (bubblemaninmazeaudioclip);
			}
			speed.y = -10f;
			//			Vector3 pos = transform.position;
			//			pos.y += -0.08f;
			//			transform.position = pos;
			//		//	walking = true;


		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			bubblemaninmazeaudiosource.Stop ();


		}


		rigidbody.velocity = speed;

		//		if (!Input.anyKey) {
		//			walking = false;
		//		}

		//	anim.SetBool ("walking", walking);
	}
}

		
	

