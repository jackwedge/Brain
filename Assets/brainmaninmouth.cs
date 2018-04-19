using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainmaninmouth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	void OnMouseDown(){
		//		Debug.Log("click");
		if (MAINCAMERA.Me.state == 7  && Input.GetMouseButtonDown (0)) {
			
			MAINCAMERA.Me.state = 8;

		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
