using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterBoxController : MonoBehaviour {

	static GameObject[] whiteboxes = new GameObject [7];
	public int boxnumber;


	bool box1ison= true;
	public GameObject whitebox;
	AlphabetController mymanager;
	public int	myboxnumber=1;
//	public int myboxnumber2 = 2;
//	public int myboxnumber3 = 3;
//	public int myboxnumber4 = 4;
//	public int myboxnumber5 = 5;
//	public int myboxnumber6 = 6;
//	public int myboxnumber7 = 7;
	Sprite yellowbox;
	// Use this for initialization
	void Start () {
		whiteboxes = GameObject.FindGameObjectsWithTag ("box");
		mymanager = GetComponentInParent<AlphabetController> ();
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnMouseDown (){
		Debug.Log ("leterchosen" + myboxnumber);
		mymanager.setAlphabetSpriterenderer (this.GetComponent<SpriteRenderer> (), myboxnumber);
		//mymanager.gameObject.GetComponent<SpriteRenderer> ().color = new Color (255, 0, 200);
	//	mymanager.MousePressed (mykeynumber);
		for (int i = 0; i < whiteboxes.Length; i++) {
			whiteboxes[i].GetComponent<SpriteRenderer>().color=Color.white;
		}
		whiteboxes[boxnumber].GetComponent<SpriteRenderer>().color=Color.red;

	}





}
