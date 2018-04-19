using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_1buttoncontroller : MonoBehaviour {
	
	public SpriteRenderer SR;
	//declaring from visual interface 


public	int buttonNumber;

	public	puzzle_1controller managerSolvedPuzzle;
	float timer;
	bool hasclicked=false;
	bool mouseIsOver= false;

	public	Color yellow;

	public Color green;


	Sprite buttonOnSprite;
	// Use this for initialization

	void Start () {
		
		SR = GetComponent<SpriteRenderer> ();
		//telling the interface which assets are being effected-storing in the SR variable
		buttonOnSprite = SR.sprite;

	//	SR.sprite = null;
		//hide the sprites

	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown(0)) {
		//	hasclicked = true;
		//Debug.Log ("testmouseinput");
		//	SR.sprite = buttonOnSprite;
		//timer += Time.deltaTime;

		//}


	//	if (timer > 0) {
		//	timer -= Time.deltaTime;

//		} else {
//
//			hasclicked = false;
//			//SR.sprite = null;
//			//timer = 0;
//
//
//		
//		}
	
		if (hasclicked == true) {
			SR.color = green; 

		} else if (mouseIsOver == true) {
			SR.color = yellow;

		} else {
			SR.color = new Color (0, 0, 0, 0);
		}
	}

	void OnMouseDown (){
		//SR.sprite = buttonOnSprite;
		hasclicked = true;
		//timer = 6;
		managerSolvedPuzzle.Pressed (buttonNumber);

	}

	public void PuzzleFailed(){

		hasclicked = false;

}


	void OnMouseOver ()
	{
		mouseIsOver = true;


		
	}

	void OnMouseExit(){
		mouseIsOver = false;
			//SR.sprite = null;
	}

		//use oncollision enter
	
		
}


