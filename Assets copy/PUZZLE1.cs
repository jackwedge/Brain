using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUZZLE1 : MonoBehaviour {


	public Animator anim;
	public SpriteRenderer SR;
//	bool walker = false;
	//bool idle1 = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	

		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = transform.position;
			pos.x += 0.03f;
			transform.position = pos;
	//		walker = true;
			//idle1 = false;
			SR.flipX = false;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = transform.position;
			pos.x += -0.03f;
			transform.position = pos;
	//		walker = true;
			//idle1 = false;
			SR.flipX = true;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = transform.position;
			pos.y += +0.03f;
			transform.position = pos;
	//		walker = true;
			//idle1 = false;
			//	transform.position.x += 1;


		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = transform.position;
			pos.y += -0.03f;
			transform.position = pos;
		//	walker = true;
		//	idle1 = false;

		}



}
}