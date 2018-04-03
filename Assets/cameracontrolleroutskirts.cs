using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrolleroutskirts : MonoBehaviour {

	public Vector3 colorbrainposition;
	public Vector3 blackandwhitebrain;
	public cameracontrollerpuzzle3 cameraoutskirtsposition;
	public int state = 0;
	public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (state == 0) {
			transform.position = colorbrainposition;

		}


		if (state == 1) {
			transform.position = blackandwhitebrain;
		}


		if (state == 0) {

			if (Input.GetKeyDown ("space")) {


				state = 1;


			}
		}

		else if (state == 1) {


			if (Input.GetKeyDown ("space")) {
				//transform.position = Puzzle2position;
				state = 0;


			}
		}
		
	}
}
