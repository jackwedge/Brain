using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class bubblemaninfield : MonoBehaviour {

	public Animator anim;
	public SpriteRenderer SR;
	bool walking = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		SR = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {


		//bool walking = false;
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = transform.position;
			pos.x += 0.03f;
			transform.position = pos;
			walking = true;
			//SR.flipX = true;
			transform.eulerAngles = new Vector3 (0, 0, -90);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.03f;
			transform.position = pos;
			walking = true;
			//SR.flipX = false;
			transform.eulerAngles = new Vector3 (0, 0, 90);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = transform.position;
			pos.y += +0.03f;
			transform.position = pos;
			walking = true;
			transform.eulerAngles = new Vector3 (0, 0, 0);
			//	transform.position.x += 1;


		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = transform.position;
			pos.y += -0.03f;
			transform.position = pos;
			walking = true;
			transform.eulerAngles = new Vector3 (0, 0, 180);

		}

		if (!Input.anyKey) {
			walking = false;
		}


//		if Vector3 pos >
//
	

		anim.SetBool ("walking", walking);


		
	}
}







	


	
	





