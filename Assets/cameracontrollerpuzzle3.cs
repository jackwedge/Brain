using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrollerpuzzle3 : MonoBehaviour {

	float timer;
	public Vector3 intenstinesposition;
	public Vector3 pianopuzzleposition;
	public Vector3 standontongueposition;
	public Vector3 musicmouthpoisiton;

	public int state = 0;
//	public static MAINCAMERA Me;
	public Camera cam;




	// Use this for initialization
	void Start () {
		state = 0;

		cam.enabled = true;
	}




	public 	IEnumerator delay (float duration, int tempstate)
	{
		yield return new WaitForSeconds (duration);
		//transform.position = treeposition;
		//state = tempstate;

	}
	
	// Update is called once per frame
	void Update () {

			if (state == 0) {
				transform.position = intenstinesposition;

			}


		if (state == 1) {
			transform.position = standontongueposition;

		}

		if (state==2) {
			transform.position = pianopuzzleposition;
}

		if (state==3) {
			transform.position = musicmouthpoisiton;
	}


	}
}
