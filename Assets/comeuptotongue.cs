using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comeuptotongue : MonoBehaviour {

	public SpriteRenderer comeuptotongueSpriterenderer;
	public Sprite [] mysprites;
	//public comeuptotongue bubblemanontongue;
	public cameracontrollerpuzzle3 camera3;





	float timer =0f;





	float waittime =.05f;

	int interval= 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		

		//if we are not in state 1 then we don't need to run this code
		if(camera3.state != 1)
		{
			return;
		}


		//we'll only run this code if we are in state 1

		// if timer is less than waittime 
		if (timer < waittime ) {
			timer += Time.deltaTime; //increase the value of timer by a few milliseconds
			return; // stop running the function
		}

		//if we are holding the arrow key down AND if timer is now greater than the value of waittime
		if (Input.GetKey (KeyCode.RightArrow) && timer >= waittime) {
			

			comeuptotongueSpriterenderer.sprite = mysprites [interval];
			interval++;
			//increase the interval (i.e. the image to show)


			if (interval >= mysprites.Length) {
				interval = mysprites.Length - 1;


				if (interval == 54 && camera3.transform.position != camera3.standontongueposition) {
					camera3.transform.position = camera3.standontongueposition;


				}

			}
		

			timer = 0f;


		}



			if (Input.GetKey (KeyCode.LeftArrow) && timer >= waittime) {
				comeuptotongueSpriterenderer.sprite = mysprites [interval];

				interval--;

				if (interval <= 0) {
					interval = 0;

				camera3.state = 0;

			
				}




				timer = 0;

			}
		}




		//if (bubblemanwiggling.transform.position.x > 30) {
		//Debug.Log ("YIPPPIE");






	}





		
	

