using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingcontrollerfinalbrain : MonoBehaviour {

	public SpriteRenderer SR;
	public bool walking = false;
	public Animator anim;







	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = transform.position;
			pos.x += 0.05f;
			transform.position = pos;
		//	walking = true;
		//	SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.05f;
			transform.position = pos;
		//	walking = true;

		//	SR.flipX = true;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = transform.position;
			pos.y += +0.05f;
			transform.position = pos;
		//	walking = true;

			//	transform.position.x += 1;


		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = transform.position;
			pos.y += -0.05f;
			transform.position = pos;
		//	walking = true;


		}

//		if (!Input.anyKey) {
//			walking = false;
//		}

	//	anim.SetBool ("walking", walking);
	}
}
