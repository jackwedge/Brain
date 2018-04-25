using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblemanstopyelllinganimationcontroller : MonoBehaviour {

	public Animator animationcontroller; 

	bool react=false;

	public AudioSource payattentionsource;
	public AudioClip payattentionclip;




	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown (){




		if (Input.GetMouseButton (0)) {


			Debug.Log ("areyouworkingtoday?");
			if (!payattentionsource.isPlaying) {
				payattentionsource.PlayOneShot (payattentionclip);
			}




			//animationcontroller.SetBool = react;
			animationcontroller.Play ("hint");
			react =true;

			Debug.Log ("areyouworkingtoday?");
		} 

//
		else {
			animationcontroller.Play ("bubblemansitting");

		}
	}
	}


