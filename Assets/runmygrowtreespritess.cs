using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runmygrowtreespritess : MonoBehaviour {

	public SpriteRenderer reincarnationSpriterenderer;
	public Sprite [] mysprites;




	int interval= 0;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;
	public Vector3 treegoodbyeposition;
//	public Camera cam;
	public endingcameracontroller fincamera;

//	public int state = 0;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (fincamera.state == 3) {
			if (Input.GetKey (KeyCode.RightArrow)) {

				if (interval < mysprites.Length) {
					reincarnationSpriterenderer.sprite = mysprites [interval];
					interval++;
				}

		}


	



//				if (interval >= mysprites.Length) {
//					//interval = mysprites.Length - 1;
//					}
//				}
				
//
//				if (Input.GetKey (KeyCode.LeftArrow) ) {
//
//					if (interval < mysprites.Length) {
//					reincarnationSpriterenderer.sprite = mysprites [interval];
//
//					}
//
//
//
//					interval--;
//
//					if (interval <= 0) {
//						interval = 0;
//					}
//
//				
//
//
//				}

			}
		}
		
}	
