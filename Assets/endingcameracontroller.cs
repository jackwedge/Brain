using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class endingcameracontroller : MonoBehaviour {
	float timer;

	public GameObject button;
	
	public Vector3 myskinisunravelingrposition;
	public Vector3 skeletonfallsoverrposition;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;
	public Vector3 treegoodbyeposition;

	public AudioSource skinunravelingsource;
	public AudioClip skinunravelingclip;


	public AudioClip windchimesclip;
	public AudioSource windchimessource;


	public AudioSource treefallingsource;
	public AudioClip treefallingclip;



	public AudioSource youescapedwindsource;
	public AudioClip youescapedwindclip;



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


		hideshowButton ();


		if (state == 0) {
			transform.position = myskinisunravelingrposition;

		
//			youescapedwindsource.clip = youescapedwindclip;
//			youescapedwindsource.Play ();
//


		



//			youescapedwindsource.clip = youescapedwindclip;
//			youescapedwindsource.Play ();

			if (!youescapedwindsource.isPlaying) {
				youescapedwindsource.PlayOneShot (youescapedwindclip);
			}


//			if (!skinunravelingsource.isPlaying) {
//				skinunravelingsource.PlayOneShot (skinunravelingclip);
//			}




				timer += Time.deltaTime;
				if (timer > 6) {
				treefallingsource.clip = treefallingclip;
				treefallingsource.Play ();
				transform.position = skeletonfallsoverrposition;
					state = 1;
//				if (!treefallingsource.isPlaying) {
//					treefallingsource.PlayOneShot (treefallingclip);
//				}



				}
			}






	if (state == 1) {


			transform.position = skeletonfallsoverrposition;


			timer += Time.deltaTime;
			if (timer > 10) {
				transform.position = runoutofskullrposition;
				state = 2;

				youescapedwindsource.clip = youescapedwindclip;
				youescapedwindsource.Stop ();
			}
		}

		if (state == 2) {
			transform.position = runoutofskullrposition;

			youescapedwindsource.clip = youescapedwindclip;
			youescapedwindsource.Stop ();




			if (!windchimessource.isPlaying) {
				windchimessource.PlayOneShot (windchimesclip);
			}





		}

		if (state == 3) {
			transform.position = finalfieldrposition;
			youescapedwindsource.clip = youescapedwindclip;
			youescapedwindsource.Play ();

		
	}

		if (state == 4) {
			transform.position = treegrowsrposition;

			youescapedwindsource.clip = youescapedwindclip;
			youescapedwindsource.Play ();

		}


		if (state == 5) {
			transform.position = treegoodbyeposition;
			youescapedwindsource.clip = youescapedwindclip;
			youescapedwindsource.Play ();
		}
}

	void hideshowButton() //This is where all the hint button stuff works, If you want to make changes it will be in here
	{
		if (transform.position == runoutofskullrposition ) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}
		else 
		{
			button.gameObject.SetActive(false);
		}
	}






}
