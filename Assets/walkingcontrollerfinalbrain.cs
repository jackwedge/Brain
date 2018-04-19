using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingcontrollerfinalbrain : MonoBehaviour {

	public SpriteRenderer SR;
	public bool walking = false;
	public Animator anim;
	public Rigidbody2D rigidbody;







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

		//	transform.position = pos;
		//	walking = true;
		//	SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			speed.x = -10f;
//			Vector3 pos = transform.position;
//			pos.x += -0.08f;
//			transform.position = pos;
		//	walking = true;

		//	SR.flipX = true;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			speed.y = +10f;
//			Vector3 pos = transform.position;
//			pos.y += +0.08f;
//			transform.position = pos;
//		//	walking = true;

			//	transform.position.x += 1;


		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			speed.y = -10f;
//			Vector3 pos = transform.position;
//			pos.y += -0.08f;
//			transform.position = pos;
//		//	walking = true;


		}


		rigidbody.velocity = speed;

//		if (!Input.anyKey) {
//			walking = false;
//		}

	//	anim.SetBool ("walking", walking);
	}
}
