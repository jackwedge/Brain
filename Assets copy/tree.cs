using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {



		public Animator anim;
		public SpriteRenderer SR;
		bool hatch = false;


	// Use this for initialization
	void Start () {
		anim = transform.GetComponent<Animator>();
		print ("set animator");

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			hatch = true;
		}

		anim.SetBool ("hatch", hatch);
	}
}
