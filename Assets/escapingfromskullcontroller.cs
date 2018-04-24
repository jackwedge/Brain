using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapingfromskullcontroller : MonoBehaviour {

	public Vector3 myskinisunravelingrposition;
	public Vector3 skeletonfallsoverrposition;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;
	public Vector3 treegoodbyeposition;
	public Camera cam;
	public SpriteRenderer escapefromskullSpriterenderer;
	public Sprite [] mysprites;
	public escapingfromskullcontroller bubblemanisfree;
	public endingcameracontroller fincamera;


	public AudioClip slidingthruintestinessound;
	public AudioSource slidingthruintestinessource;

	//public int state = 0;

	//public Camera cam;

	float timer;

	float waittime =0.1f;

	int interval= 0;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("updateforstage2");

		if (fincamera.state == 2) {


		if (timer > 0) {
			timer -= Time.deltaTime;
		}




		if (Input.GetKey (KeyCode.RightArrow) && timer <= 0) {
				Debug.Log ("runoutofeyesocket?");

			if (interval < mysprites.Length) {
				escapefromskullSpriterenderer.sprite = mysprites [interval];

			}



			interval++;

				if (!slidingthruintestinessource.isPlaying) {
					slidingthruintestinessource.PlayOneShot (slidingthruintestinessound);
				}


			if (interval >= mysprites.Length) {
				//interval = mysprites.Length - 1;
			}

			timer += waittime;



			//	timer += waittime;
			Debug.Log("areuworking"+interval);



			if (interval == 45) {

				fincamera.state = 3;
				transform.position = finalfieldrposition;



				timer += Time.deltaTime;
					if (timer > 8) {
						transform.position = treegoodbyeposition;
				
					}
			}
		}


			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				if (slidingthruintestinessource.isPlaying) {


					slidingthruintestinessource.clip = slidingthruintestinessound;
					slidingthruintestinessource.Stop ();

				}
			}

		if (Input.GetKey (KeyCode.LeftArrow) && timer <= 0) {

			if (interval < mysprites.Length) {
				escapefromskullSpriterenderer.sprite = mysprites [interval];

			}



				interval--;

				if (interval <= 0) {
					interval = 0;
				}

			timer += waittime;
				//timer += waittime;

			//	if (interval == 46) {

				//	transform.position = finalfieldrposition;

		//	}


		
	}

}
}
}