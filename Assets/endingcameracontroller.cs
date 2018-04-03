using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingcameracontroller : MonoBehaviour {
	float timer;
	
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


	public 	IEnumerator delay (float duration, int tempstate)
	{
		yield return new WaitForSeconds (duration);
		transform.position = myskinisunravelingrposition;
		state = tempstate;

	}
	
	// Update is called once per frame
	void Update () {


		if (state == 0) {
			transform.position = myskinisunravelingrposition;
				timer += Time.deltaTime;
				if (timer > 6) {
				transform.position = skeletonfallsoverrposition;
					state = 1;
				}
			}






	if (state == 1) {
			transform.position = skeletonfallsoverrposition;
			timer += Time.deltaTime;
			if (timer > 12) {
				transform.position = runoutofskullrposition;
				state = 2;
			}
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
