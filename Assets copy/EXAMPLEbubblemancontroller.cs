using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xbubblemancontroller : MonoBehaviour {

	public Animator Anim;
	public SpriteRenderer SR;


	void Start (){
		GetComponent<SpriteRenderer> ();
	}

	void Update (){

		bool walking = false;
		if (Input.GetKey(KeyCode.RightArrow)){
			Vector3 pos =transform.position;
			pos.x+= 0.03f;
			transform.position= pos;
			walking = true;
			SR.flipX = true;
		}

		if (Input.GetKey (KeyCode.LeftArrow)){
			Vector3 pos=transform.position;
			pos.x+= -0.03f;
			transform.position=pos;
			walking = true;
			SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.UpArrow)){
			Vector3 pos=transform.position;
			pos.y+= +0.03f;
			transform.position=pos;
			walking = true;
		//transform.position.x += 1;

	
	}

		if (Input.GetKey (KeyCode.DownArrow)){
			Vector3 pos=transform.position;
			pos.y+= -0.03f;
			transform.position=pos;
			walking = true;

		}

		Anim.SetBool ("Walking", walking);
	}
}