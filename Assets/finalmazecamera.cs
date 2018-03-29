using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalmazecamera : MonoBehaviour {

	public Vector3 centerbraincolorposition;
	public Vector3 centerbrainblackandwhilerposition;
	public Vector3 bigbrainrposition;
	public Vector3 myskinisunravelingrposition;
	public Vector3 skeletonfallsoverrposition;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;

	public int state = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if (state == 0) {
			transform.position = bigbrainrposition;
	}



		transform.position=bubblemantraveling.position;
		transform.position=new Vector3(	transform.position.x,transform.position.y,-10);

	}
}
