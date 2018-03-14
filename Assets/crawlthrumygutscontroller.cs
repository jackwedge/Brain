using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawlthrumygutscontroller : MonoBehaviour {



	public SpriteRenderer bubblemaningutSpriterenderer;
	public Sprite [] mysprites;
	public crawlthrumygutscontroller bubblemanwiggling;

	//public int state = 0;

	float timer;

	float waittime =0.1f;

	int interval= 0;




	// Use this for initialization
	void Start () {

		int state = 0;

	}


	void Update () {

		var thisState = GameObject.Find ("Main Camera").GetComponent<cameracontrollerpuzzle3> ().state;


		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (thisState == 0 &&Input.GetKey (KeyCode.RightArrow) && timer<=0) {
			bubblemaningutSpriterenderer.sprite = mysprites [interval];
			interval++;


			if (interval >= mysprites.Length) {
				interval = mysprites.Length - 1;
			}


			timer += waittime;




		}

		if (thisState == 0 &&Input.GetKey (KeyCode.LeftArrow) && timer<=0) {
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
	

