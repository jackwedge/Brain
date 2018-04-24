using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblemanstopyelllinganimationcontroller : MonoBehaviour {

	public Animator animationcontroller; 






	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown (){




		if (Input.GetMouseButton (0)) {
			animationcontroller.Play ("hint");

			Debug.Log ("areyouworkingtoday?");
		} 

//
		else {
			animationcontroller.Play ("bubblemansitting");

		}
	}
	}


