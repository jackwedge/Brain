using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cameracontrollerpuzzle3 : MonoBehaviour {

	float timer;
	public Vector3 intenstinesposition;
	public Vector3 pianopuzzleposition;
	public Vector3 standontongueposition;
	public Vector3 musicmouthpoisiton;
	public cameracontrollerpuzzle3 camera3;

	public int state = 0;

//	public static MAINCAMERA Me;
	public Camera cam;




	// Use this for initialization
	void Start () {



	
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

		if (state == 2) {
			transform.position = pianopuzzleposition;
		}

		if (state == 3) {
			transform.position = musicmouthpoisiton;
		}


		if (state == 4) {
			transform.position = standontongueposition;
		}

		//state = 0;



		if (Input.GetKeyDown (KeyCode.Q)) {
			state = 1;
		}

		//this is toggling between piano puzzle and standing on tongue position with space bar
	
		if (state == 2) {

			if (Input.GetKeyDown ("space")) {

			
				state = 4;
			

			}
		}

		else if (state == 4) {
			
		
			if (Input.GetKeyDown ("space")) {
				//transform.position = Puzzle2position;
				state = 2;


			}
		}

		//you need to set up a timer here
		if (state==3){

			SceneManager.LoadScene(3);


		}



	


	}


}

