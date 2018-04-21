using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrolleroutskirts : MonoBehaviour {

	public Vector3 colorbrainposition;
	public Vector3 blackandwhitebrain;
	public cameracontrollerpuzzle3 cameraoutskirtsposition;
	public int state = 0;
	public Camera cam;

	public AudioSource puzzle1buttonsource;
	public AudioClip puzzle1buttonsound;

	public AudioSource indianoceansource;
	public AudioClip indianoceanclip;


	public AudioSource insidebrainambiancesource;
	public AudioClip insidebrainsound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (state == 0) {
			transform.position = colorbrainposition;
			if (!indianoceansource.isPlaying) {
				indianoceansource.PlayOneShot (indianoceanclip);


				insidebrainambiancesource.Stop(); 
			}


		}


		if (state == 1) {
			transform.position = blackandwhitebrain;


			if (!insidebrainambiancesource.isPlaying) {
				insidebrainambiancesource.PlayOneShot (insidebrainsound);
			}



		indianoceansource.Stop(); 
		}


//		if (state == 0) {
//
//			if (Input.GetKeyDown ("space")) {
//
//
//				if (!puzzle1buttonsource.isPlaying) {
//					puzzle1buttonsource.PlayOneShot (puzzle1buttonsound);
//				}
//
//				state = 1;
//
//			
//			}
//
//			}
//		else if (state == 1) {
//
//
//			if (Input.GetKeyDown ("space")) {
//
//					state = 0;
//				//transform.position = Puzzle2position;
//
//				if (! puzzle1buttonsource.isPlaying) {
//					puzzle1buttonsource.PlayOneShot ( puzzle1buttonsound);
//				}
//
//				state = 0;
//
//
//
//
//			}
//		}
//		
//}
//}
//





if (state == 0) {

	if (Input.GetKeyDown ("space")) {

				if (!puzzle1buttonsource.isPlaying) {
										puzzle1buttonsource.PlayOneShot (puzzle1buttonsound);
									}


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

