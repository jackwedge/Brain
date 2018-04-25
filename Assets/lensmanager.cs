using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lensmanager : MonoBehaviour {

	public puzzle2controller lens1 ;
	public puzzle2controller lens2 ;
	public puzzle2controller lens3 ;
	public puzzle2camera cam;



	public bool youreawinner = false;

Sprite lens1sprite;
 Sprite lens2sprite;
 Sprite lens3sprite;


	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {


		lens1sprite = lens1.GetComponent<SpriteRenderer> ().sprite;
		lens2sprite = lens2.GetComponent<SpriteRenderer> ().sprite;
		lens3sprite = lens3.GetComponent<SpriteRenderer> ().sprite;


		string lens1Name = lens1sprite.name;
		string lens2Name = lens2sprite.name;
		string lens3Name = lens3sprite.name;
		Debug.Log (lens1Name);

		if (lens1Name.Equals ("eyeball puzzle0049") && lens2Name.Equals ("eyeball puzzle0052") && lens3Name.Equals ("eyeball puzzle0097") && cam.iseyeballpov){
	
			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

			}

		else if (lens1Name.Equals ("eyeball puzzle0046") && lens2Name.Equals ("eyeball puzzle0055") && lens3Name.Equals ("eyeball puzzle0094") && cam.iseyeballpov){

			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

		}


		else if (lens1Name.Equals ("eyeball puzzle0031") && lens2Name.Equals ("eyeball puzzle0070") && lens3Name.Equals ("eyeball puzzle0079") && cam.iseyeballpov){

			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

		}



		else if (lens1Name.Equals ("eyeball puzzle0043") && lens2Name.Equals ("eyeball puzzle0058") && lens3Name.Equals ("eyeball puzzle0091") && cam.iseyeballpov){

			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

		}

		else if (lens1Name.Equals ("eyeball puzzle0030") && lens2Name.Equals ("eyeball puzzle0073") && lens3Name.Equals ("eyeball puzzle0076") && cam.iseyeballpov){

			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

		}


		else if (lens1Name.Equals ("eyeball puzzle0034") && lens2Name.Equals ("eyeball puzzle0067") && lens3Name.Equals ("eyeball puzzle0082") && cam.iseyeballpov){

			youreawinner = true;
			Debug.Log ("YOUREAWINNERPLSWORK");

		}

}
}
 