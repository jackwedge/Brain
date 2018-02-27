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

	public int state = 0;





	// Use this for initialization
	void Start ()
	{
		
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

			}
		}

		else if (state == 1) {
			transform.position = Puzzle2solvedposition;
			if (Input.GetKeyDown ("space")) {
				//transform.position = Puzzle2position;
				state = 0;
			}
		}
	}
}

	
	
