using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2controller : MonoBehaviour {
	public SpriteRenderer lensSpriterenderer;
	public Sprite [] mysprites;
	public puzzle2controller lens2;


//	public Sprite[] currentlens1 = mysprites[7];
//	public Sprite[] currentlens2 = mysprites[7];
//	public Sprite[] currentlens3 = mysprites[7];
	public int	mylensnumber=1;

	public Vector3 Puzzle2position;
	public Vector3 Puzzle2solvedposition;
	public Vector3 Puzzle2lookoutside;
	public Vector3 gothrougheyesocket;
	public lensmanager manager;

	public puzzle2camera camerababy;

	public int state = 0;





	int interval= 0;

	// Use this for initialization
	void Start () {
		// prints hello
		string s = "press space bar to change perspectives";

		lensSpriterenderer = GetComponent<SpriteRenderer> ();

		
	}
	
	// Update is called once per frame
	void Update () {

	



		
	}




		
	void OnMouseDown (){
		if (camerababy.state == 0) {

			lensSpriterenderer.sprite = mysprites [interval % 8];
			if (lens2 != null) {
				lens2.lensSpriterenderer.sprite = mysprites [interval % 8];
			}
			interval++;
		}

	}


}

