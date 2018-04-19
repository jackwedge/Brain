using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MAINCAMERA : MonoBehaviour
{
	
	public GameObject button;
	public AudioSource musicsource;
	public AudioSource bubblerap;
	public AudioClip windchimes;
	public AudioSource dissloveallletters;
	public AudioClip dissolveletterssound;
	public AudioSource hellotree;
	public AudioClip hellotreesound;

	float timer;
	//	bool starttimer;
	public Vector3 fieldposition;
	public Vector3 trapposition;
	public Vector3 titleposition;
	public Vector3 treeposition;
	public Vector3 puzzle1position;
	public Vector3 youareeatenposition;
	public Vector3 welcome2brainposition;
	public Vector3 Puzzle2position;
	public Vector3 dooropening;
	public Vector3 Doorisopen;
	public Vector3 Puzzle2solvedposition;
	public Vector3 eyeballsocket;



	public bubblemaninfield guy;
	public static MAINCAMERA Me;
	public GameObject forklift;

	public walkcycle bubbleman;

	public int state = 0;

	public GameObject B;
	public GameObject R;
	public GameObject A;
	public GameObject I;
	public GameObject N;
	public GameObject BrainAnim;


	// Use this for initialization
	void Start ()
	{


	//state = 6;
	
		Me = this;
		//Sound.PlayOneShot (StartSound);
	}
	
	// Update is called once per frame










	public 	IEnumerator delay (float duration, int tempstate)
{
yield return new WaitForSeconds (duration);
	transform.position = treeposition;
		state = tempstate;

}




	void Update ()	{

		hideshowButton ();



//		Debug.Log ("State: " + state);
		

		if (state == 0) {

			if (!musicsource.isPlaying) {
				musicsource.PlayOneShot (windchimes);
			}



			
			transform.position = titleposition;
		
			if (Input.GetMouseButton (0)) {

				if (!dissloveallletters.isPlaying) {
					dissloveallletters.PlayOneShot (dissolveletterssound);
				}
			


				Destroy (B);
				Destroy (R);
				Destroy (A);
				Destroy (I);
				Destroy (N);

				BrainAnim.SetActive (true);

				StartCoroutine (delay (3, 1));
			

			}










			if (state != 0) {

				musicsource.Stop (); 

			}


	




		



			if (state == 2) {
				timer += Time.deltaTime;
				if (timer > 5) {
					transform.position = fieldposition;
					state = 3;
				}
			}
			if (state == 3) {
				timer = 0;
				if (guy.transform.position.x > 30 || guy.transform.position.x < 11 ||
				   guy.transform.position.y > 5 || guy.transform.position.y < -5) {
				
					state = 4;


					transform.position = trapposition;
					guy.transform.position = titleposition;


				}

			}


	
			if (state == 5) {
				transform.position = trapposition;
				Debug.Log ("STATE 5: " + timer);
				timer += Time.deltaTime;
				if (timer > 3) {
					transform.position = youareeatenposition;
					state = 6;
					timer = 0;
				}
				
			}

			if (state == 6) {
				timer += Time.deltaTime;
				if (timer > 3) {
					transform.position = welcome2brainposition;
					state = 7;
				}
			}

			if (state == 8) {
				transform.position = puzzle1position;

			}


			if (state == 7) {
				transform.position = welcome2brainposition;
				//	SceneManager.LoadScene ("PUZZLE 2");
			}




			if (state == 9) {
				transform.position = dooropening;
			}

			if (state == 10) {
				transform.position = Doorisopen;
			}


			if (state == 11) {
				transform.position = eyeballsocket;
			}



			if (Input.GetKeyDown (KeyCode.F)) {
				state = 11;
			}


			if (Input.GetKeyDown (KeyCode.D)) {
				state = 5;
			}







//		if (state == 8) {
//			if (Input.GetKeyDown (KeyCode.Space))
//				Debug.Log ("Space key was pressed.");
//
//			if (Input.GetKeyUp (KeyCode.Space))
//				Debug.Log ("Space key was released.");
//		
//			transform.position = welcome2brainposition;
//			state = 7;
		}
	}

	void hideshowButton() //This is where all the hint button stuff works, If you want to make changes it will be in here
	{
		if (transform.position == fieldposition || transform.position == treeposition || transform.position == welcome2brainposition) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}
		else
		{
			button.gameObject.SetActive(false);
		}
	}




	}



