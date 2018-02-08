using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkcyclemaincontroller : MonoBehaviour {
	bool walking = false;
	//bool turn = true;
	public Animator anim;
	public SpriteRenderer SR;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	//	transform.position = new Vector3 (33, -1, -9);


		//bool walking = false;
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = transform.position;
			pos.x += 0.04f;
			transform.position = pos;
			walking = true;
			SR.flipX = true;
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.04f;
			transform.position = pos;
			walking = true;
			SR.flipX = false;
			transform.eulerAngles = new Vector3 (0, 180, 00);
		}



		if (!Input.anyKey) {
			walking = false;
		}


		//		if Vector3 pos >
		//


		anim.SetBool ("walking", walking);



	

		
	}


}
