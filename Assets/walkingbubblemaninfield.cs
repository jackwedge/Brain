/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class walkingbubblemaninfield : StateMachineBehaviour {

	public Animator anim;
	public SpriteRenderer SR;
	bool walking = false;


	void Start (){
		//		SR = GetComponent<SpriteRenderer> ();
//		anim = transform.GetComponent<Animator>();
	//	print ("set animator");
		//print (Anim.gameObject.name);

	}

	void Update (){


		//bool walking = false;
		if (Input.GetKey (KeyCode.RightArrow)) {
			//Vector3 pos = transform.position;
			pos.x += 0.03f;
			transform.position = pos;
			walking = true;
			SR.flipX = true;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.03f;
			transform.position = pos;
			walking = true;
			SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = transform.position;
			pos.y += +0.03f;
			transform.position = pos;
			walking = true;
			//	transform.position.x += 1;


		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = transform.position;
			pos.y += -0.03f;
			transform.position = pos;
			walking = true;

		}

		if (!Input.anyKey) {
			walking = false;
		}






		anim.SetBool ("walking", walking);



	}


}


*/