using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUZZLE1 : MonoBehaviour {


	public Animator anim;
	public SpriteRenderer SR;
	bool lightOn = false;
	public string boolSet;
	float timer;
	bool startTimer;
	bool lightG;





	// Use this for initialization
	void Start () {
		SR = GetComponentInParent<SpriteRenderer> ();	
		anim = GetComponentInParent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
			anim.SetBool (boolSet, lightOn);

		if (startTimer) {
		//	timer += 1;
			timer += Time.deltaTime;
			if (timer > 5) {

				lightOn = false;


			}
		}

		if (lightOn) {
			if (Input.GetMouseButtonDown (0)) {
				startTimer = true;
				


			}
		}



		//if (Input.GetMouseButton (0)) {
			//light1 = true;

	}



	void OnMouseOver()
	{
		if (!startTimer) {
			//If your mouse hovers over the GameObject with the script attached, output this message
			lightOn = true;
			print ("mouseHit");
		}
	}


		void OnMouseExit()
		{

		if (!startTimer) {
		lightOn = false;
			//The mouse is no longer hovering over the GameObject so output this message each frame
		print("mouseOff");
		}
	}

	}

	
