﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkcycle : MonoBehaviour {

	public Animator anim ;
	public SpriteRenderer SR;
	public bool walking = false;


	// Use this for initialization
	void Start () {
		anim = transform.GetComponent<Animator>();
		print ("set animator");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = transform.position;
			pos.x += 0.03f;
			transform.position = pos;
			walking = true;
			SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.03f;
			transform.position = pos;
			walking = true;

			SR.flipX = true;
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
	
	
		anim.SetBool ("Walking", walking);

	}
}
