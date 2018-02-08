using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAINCAMERA : MonoBehaviour
{
	float timer;
	//	bool starttimer;
	public Vector3 fieldposition;
	public Vector3 trapposition;
	public Vector3 titleposition;
	public Vector3 treeposition;
	public Vector3 puzzle1position;
	public Vector3 youareeatenposition;
	public Vector3 welcome2brainposition;
	public AudioClip StartSound;
	public AudioSource Sound;

	public bubblemaninfield guy;
	public static MAINCAMERA Me;
	public GameObject forklift;

	public walkcycle bubbleman;

	public int state = 0;




	// Use this for initialization
	void Start ()
	{


	//state = 6;
	
		Me = this;
		Sound.PlayOneShot (StartSound);
	}
	
	// Update is called once per frame
	void Update ()
	{

		Debug.Log ("State: " + state);
		

		if (state == 0) {
			transform.position = titleposition;
			if (Input.GetMouseButton (0)) {
//					timer += Time.deltaTime;
//					if (timer > 3) {
				transform.position = treeposition;
				state = 1;
				
			}


//		} else if (state == 1) {
//			if (Input.GetMouseButtonDown (0)) { 
//				state = 2;
//
//			}
		} else if (state == 2) {
			timer += Time.deltaTime;
			if (timer > 5) {
				transform.position = fieldposition;
				state = 3;
			}
		}
		if (state == 3) {
			timer = 0;
			if (guy.transform.position.x > 30|| guy.transform.position.x < 11|| 
				guy.transform.position.y > 5|| guy.transform.position.y < -5) {
				
				state = 4;


				transform.position = trapposition;
				guy.transform.position = titleposition;


			}

		}


	
				if (state ==5) {
			transform.position=trapposition;
			Debug.Log ("STATE 5: " + timer);
					timer += Time.deltaTime;
					if (timer > 3) {
						transform.position = youareeatenposition;
						state = 6;
			timer = 0;
					}
				
			}

		if (state == 6) {
			timer += Time.deltaTime;
			if (timer > 3) {
				transform.position = welcome2brainposition;
				state = 7;
			}
		}

	if (state == 8) {
		transform.position = puzzle1position;

		}


		if (state==7){
			transform.position= welcome2brainposition;

		}

//		if (state == 8) {
//			if (Input.GetKeyDown (KeyCode.Space))
//				Debug.Log ("Space key was pressed.");
//
//			if (Input.GetKeyUp (KeyCode.Space))
//				Debug.Log ("Space key was released.");
//		
//			transform.position = welcome2brainposition;
//			state = 7;
		}



		}
