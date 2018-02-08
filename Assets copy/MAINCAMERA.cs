using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAINCAMERA : MonoBehaviour {
	float timer;
//	bool starttimer;
	public Vector3 fieldposition;
	public Vector3 brainposition;
	public bubblemaninfield guy;

	public int state = 0;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (state == 0) {
			if (Input.GetMouseButton (0)) {
				state = 1;
			}
			}

		if (state == 1) {
			timer += Time.deltaTime;
			if (timer > 5) {
				transform.position = fieldposition;
				state = 2;
				
				}
			}

		

	if (state == 2) {
			if (guy.transform.position.x > 30)

			{state = 3;
				transform.position = brainposition;
			}
		}


	}
}
