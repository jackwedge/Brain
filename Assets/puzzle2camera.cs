

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class puzzle2camera : MonoBehaviour
{


	public GameObject button;
	public Vector3 Puzzle2position;
	public Vector3 Puzzle2solvedposition;
	public Vector3 Puzzle2lookoutside;
	public Vector3 gothrougheyesocket;
	public lensmanager manager;
	public AudioClip underwaterbreathsound;
	public AudioSource underwaterbreathsource;
	public AudioClip backwardsbreathingsound;
	public AudioSource backwardsbreathingsource;

	public AudioClip hellotreesound;
	public AudioSource hellotreesource;

	public int state = 0;


	public bool iseyeballpov=false;


	// Use this for initialization
	void Start ()
	{
		
		state = 0;
	}
	
	// Update is called once per frame
	void Update ()


	{

		hideshowButton ();




		//	if (Input.GetKeyDown("space"))
		//		print("dogman grows into a planet giant");

		//	Debug.Log ("State: " + state);


		if (state == 0) {
		
		


			transform.position = Puzzle2position;
			if (Input.GetKeyDown ("space")) {
				
				//transform.position = Puzzle2solvedposition;
				state = 1;
				iseyeballpov = false;

			}


			if (!hellotreesource.isPlaying) {

				hellotreesource.clip = hellotreesound;
				hellotreesource.Play ();
			}




			if (!backwardsbreathingsource.isPlaying ) {
				backwardsbreathingsource.clip= (backwardsbreathingsound);

				backwardsbreathingsource.Play ();


			}

		}

		else if (state == 1) {
			transform.position = Puzzle2solvedposition;
			//Debug.Log ("FUCKFUCK");
			iseyeballpov = true;
			if (Input.GetKeyDown ("space")) {
				//transform.position = Puzzle2position;
				state = 0;
			}
		}

		else if (state == 2) {
			transform.position = Puzzle2lookoutside; 
			iseyeballpov = true;
		
			//Start coroutine again for 8 seconds
			StartCoroutine(delay(6, 4));
		}
		else if (state == 3) {
			transform.position = gothrougheyesocket;
		}

		else if (state == 4) {
			SceneManager.LoadScene(2);
		}

		// if puzzle is correct
		if (manager.youreawinner && iseyeballpov){
			Debug.Log ("happydays");
			StartCoroutine(delay(3, 2));

		}





	}






	IEnumerator delay (float duration, int newState)
	{
		//Debug.Log ("startingdelay");
		yield return new WaitForSeconds (duration);
		state = newState;


		
		//StartCoroutine (delay (8)); find another place to start this coroutine




	}





	void hideshowButton() //This is where all the hint button stuff works, If you want to make changes it will be in here
	{
		if (transform.position == Puzzle2position) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}
		else
		{
			button.gameObject.SetActive(false);
		}
	}




//	void SwitchStates(){
//
//		switch (state) {
//		case 0:
//			//set camera to x
//			break;
//		case 1:
//			// set camera 
//			break;
//
//		}
//	}
}





	
