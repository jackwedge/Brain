﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crawlingcontrol : MonoBehaviour {


	public SpriteRenderer crawlingbubblemanSpriterenderer;
	public Sprite [] mysprites;
	public crawlingcontrol bubblemangoing;



	float timer;

	float waittime =0.1f;

	int interval= 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//
		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (MAINCAMERA.Me.state == 11 && Input.GetKey (KeyCode.RightArrow) && timer <= 0) {
			crawlingbubblemanSpriterenderer.sprite = mysprites [interval];
			interval++;


			if (interval >= mysprites.Length) {
				interval = mysprites.Length - 1;
			}





			timer += waittime;


			if (interval == 48) {
				//Debug.Log ("changinglocations");
				SceneManager.LoadScene(1);


			}


		



		}

		if (MAINCAMERA.Me.state == 11 && Input.GetKey (KeyCode.LeftArrow) && timer <= 0) {
			crawlingbubblemanSpriterenderer.sprite = mysprites [interval];

			interval--;

			if (interval <= 0) {
				interval = 0;
			}


			timer += waittime;

		}




		if (bubblemangoing.transform.position.x > 30) {
			Debug.Log ("YIPPPIE");
	
		}
	}





}

