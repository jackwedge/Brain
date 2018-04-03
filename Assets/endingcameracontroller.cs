using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingcameracontroller : MonoBehaviour {
	
	public Vector3 myskinisunravelingrposition;
	public Vector3 skeletonfallsoverrposition;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;
	public Camera cam;
	public int state = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (state == 0) {
			transform.position = myskinisunravelingrposition;

		}




		if (state == 1) {
			transform.position = skeletonfallsoverrposition;

		}

		if (state == 2) {
			transform.position = runoutofskullrposition;
		}

		if (state == 3) {
			transform.position = finalfieldrposition;
		
	}

		if (state == 4) {
			transform.position = treegrowsrposition;

		}
}
}
