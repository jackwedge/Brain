﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickondoorgo2eyeball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		
	}

	void OnMouseDown(){
		//		Debug.Log("click");
		if (MAINCAMERA.Me.state == 10  && Input.GetMouseButtonDown (0)) {

			MAINCAMERA.Me.state = 11;

		}

	}
}
