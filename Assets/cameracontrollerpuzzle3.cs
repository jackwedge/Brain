using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cameracontrollerpuzzle3 : MonoBehaviour {

	public GameObject button;

	float timer;
	public Vector3 intenstinesposition;
	public Vector3 pianopuzzleposition;
	public Vector3 standontongueposition;
	public Vector3 musicmouthpoisiton;


	public cameracontrollerpuzzle3 camera3;

	public AudioSource chimerssource;
	public AudioClip chimersclip;

	public AudioSource scubasource;
	public AudioClip scubaclip;

	public AudioClip whisperingdutchsound;
	public AudioSource whisperingdutchsource;


	public AudioSource brokenharmoniumsource;
	public AudioClip brokenharmoniumclip;
	public int state = 0;

//	public static MAINCAMERA Me;
	//public Camera cam;




	// Use this for initialization
	void Start () {



	
	//	cam.enabled = true;
	}




	public 	IEnumerator delay (float duration, int tempstate)
	{
		yield return new WaitForSeconds (duration);
		//transform.position = treeposition;
		//state = tempstate;

	}
	
	// Update is called once per frame
	void Update () {


		hideshowButton ();







		if (state == 0) {
			transform.position = intenstinesposition;

			if (!scubasource.isPlaying) {
				scubasource.PlayOneShot (scubaclip);
			}


			if (!whisperingdutchsource.isPlaying) {
				whisperingdutchsource.PlayOneShot (whisperingdutchsound);
			}






		}

		if ( state != 0) {

			scubasource.Stop(); 

			whisperingdutchsource.Stop ();



		}


		if (state == 1) {
			transform.position = standontongueposition;

			if (!chimerssource.isPlaying) {
				chimerssource.PlayOneShot (chimersclip);
		}
		}





		if (state == 2) {
			transform.position = pianopuzzleposition;


			//chimerssource.Stop(); 

			if (! brokenharmoniumsource.isPlaying) {
				brokenharmoniumsource.PlayOneShot ( brokenharmoniumclip);
			}
				

		}

		if ( state == 1) {

			brokenharmoniumsource.Stop(); 



		}





	


		if (state == 3) {
			transform.position = musicmouthpoisiton;

			if (! brokenharmoniumsource.isPlaying) {
				brokenharmoniumsource.PlayOneShot ( brokenharmoniumclip);
			}
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
				if (!chimerssource.isPlaying) {
					chimerssource.PlayOneShot (chimersclip);
				}


				}
			}


		//you need to set up a timer here
		if (state == 3) {
			timer += Time.deltaTime;
			if (timer > 8) {


				SceneManager.LoadScene (4);


			}
		}



	


	}



	void hideshowButton() //This is where all the hint button stuff works, If you want to make changes it will be in here
	{
		if (transform.position == intenstinesposition) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}



		else	if (transform.position == standontongueposition) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}


		else	if (transform.position == pianopuzzleposition) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}



		else
		{
			button.gameObject.SetActive(false);
		}
	}



}

