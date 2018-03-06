using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class puzzle2camera : MonoBehaviour
{
	public Vector3 Puzzle2position;
	public Vector3 Puzzle2solvedposition;
	public Vector3 Puzzle2lookoutside;
	public Vector3 gothrougheyesocket;
	public lensmanager manager;


	public int state = 0;


	public bool iseyeballpov=false;


	// Use this for initialization
	void Start ()
	{
		state = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{

		//	if (Input.GetKeyDown("space"))
		//		print("dogman grows into a planet giant");

		//	Debug.Log ("State: " + state);


		if (state == 0) {
			transform.position = Puzzle2position;
			if (Input.GetKeyDown ("space")) {
				
				//transform.position = Puzzle2solvedposition;
				state = 1;
				iseyeballpov = false;

			}
		}

		else if (state == 1) {
			transform.position = Puzzle2solvedposition;
			//Debug.Log ("FUCKFUCK");
			iseyeballpov = true;
			if (Input.GetKeyDown ("space")) {
				//transform.position = Puzzle2position;
				state = 0;
			
		
			}
		}

		if (state == 2) {
			transform.position = Puzzle2lookoutside; 
		}




		if (state == 3) {
			transform.position = gothrougheyesocket;
		}


		if (manager.youreawinner && iseyeballpov){
			Debug.Log ("happydays");
			StartCoroutine(delay(3));

		}



	}



	IEnumerator delay (float duration)
	{
		//Debug.Log ("startingdelay");
		yield return new WaitForSeconds (duration);
		iseyeballpov = true;
		transform.position = Puzzle2lookoutside;
		state = 2;



	}
}



	
