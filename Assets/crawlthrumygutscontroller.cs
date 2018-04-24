using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawlthrumygutscontroller : MonoBehaviour {



	public SpriteRenderer bubblemaningutSpriterenderer;
	public Sprite [] mysprites;
	public crawlthrumygutscontroller bubblemanwiggling;
	public cameracontrollerpuzzle3 camera3;

	//public AudioSource chimerssource;
	//public AudioClip chimersclip;



	public AudioSource slidingthruintestinessource;
	public AudioClip slidingthruintestinessound;


	//public int state = 0;

	float timer;

	float waittime =0.1f;

	int interval= 0;




	// Use this for initialization
	void Start () {

	

			
		
	}


	void Update () {


		if (camera3.transform.position != camera3.intenstinesposition) {

			return;
		}
			
			
		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.RightArrow) && timer<=0) {
			bubblemaningutSpriterenderer.sprite = mysprites [interval];
			interval++;



			slidingthruintestinessource.clip = slidingthruintestinessound;
			slidingthruintestinessource.Play ();



			if (interval >= mysprites.Length) {
				interval = mysprites.Length - 1;


				if (interval == 129) {

					camera3.state = 1;




					//camera3.transform.position = camera3.standontongueposition;

				


					//Debug.Log ("comeuptomymouth");
				}


			}


			timer += waittime;




		}


		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			if (slidingthruintestinessource.isPlaying) {


				slidingthruintestinessource.clip = slidingthruintestinessound;
				slidingthruintestinessource.Stop ();

			}
		}



		if (Input.GetKey (KeyCode.LeftArrow) && timer<=0) {
			bubblemaningutSpriterenderer.sprite = mysprites [interval];

			interval--;

			if (interval <= 0) {
				interval = 0;
			}


			timer += waittime;

		}




		//if (bubblemanwiggling.transform.position.x > 30) {
			//Debug.Log ("YIPPPIE");






		}

		
	}
	
	// Update is called once per frame
	

