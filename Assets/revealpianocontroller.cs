using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revealpianocontroller : MonoBehaviour {

	public SpriteRenderer revealpianoSpriterenderer;
	public Sprite [] myhiddenpianosprites;
	public Sprite [] myrevealedpianosprites;
	public Sprite [] tongueliftingupsprites;
	public cameracontrollerpuzzle3 camera3;

	public AudioClip  chimersclip;
	public AudioSource chimerssource;



	float timer =0f;


	float waittime =.05f;

	int interval= 0;


	public Sprite[] activearray;

	// Use this for initialization
	void Start () {



		activearray = myhiddenpianosprites;


	}

	void FixedUpdate(){
		




	}
	
	// Update is called once per frame
	void Update () {

		if (camera3.state == 1) {
			if (!chimerssource.isPlaying) {
				chimerssource.PlayOneShot (chimersclip);
			}
		}

//
//		if ( camera3.state != 1 & camera3.state !=4) {
//
//			chimerssource.Stop(); 
//
//
//
//		}






//		if (camera3.state = 1) {
			

			if (Time.time >= timer+waittime){
				timer = Time.time;
				revealpianoSpriterenderer.sprite = activearray[interval%activearray.Length];
				interval++;
			}

//		}

		if (activearray == tongueliftingupsprites && revealpianoSpriterenderer.sprite == tongueliftingupsprites [tongueliftingupsprites.Length-1]) {

			activearray = myrevealedpianosprites;
		
		}




		//if we are not in state 1 then we don't need to run this code
		if(camera3.state != 1)
		{
			return;
		}

				}

			
	void OnMouseDown(){

		if (camera3.state == 4) {
			camera3.transform.position = camera3.pianopuzzleposition;
			camera3.state = 2;

			timer += Time.deltaTime;
			if (timer > 2) {
				chimerssource.Stop (); 
			}
		}
	


		if (camera3.state == 1) {
			interval = 0;
			activearray = tongueliftingupsprites;
			camera3.state = 4;
		

		//	chimerssource.Stop (); 

		//	Debug.Log ("stopthefuckingchimes");



		}


		if (camera3.state == 2) {
			
			chimerssource.Stop (); 
		}




		}




	

	}
	



	
		


		
	



