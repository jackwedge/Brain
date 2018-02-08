using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCONTROLLER : MonoBehaviour {
	public Animator anim;
	public SpriteRenderer SR;

	bool dissolve = false;

	// Use this for initialization


	void Update () {

			anim.SetBool ("dissolve", dissolve);

		if (Input.GetMouseButton(1))  {
			dissolve=true;
		}

		}
			


	

		
	
	
	// Update is called once per frame



		void OnMouseOver()
		{
			//If your mouse hovers over the GameObject with the script attached, output this message
		dissolve=true;
		}

		void OnMouseExit()
		{
		dissolve = false;
			//The mouse is no longer hovering over the GameObject so output this message each frame
			
		}


}


