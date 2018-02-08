using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypressedcontroller : MonoBehaviour {

	public keyboardcontroller mymanager;
	public int mykeynumber;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown (){
		Debug.Log ("pianoplaying" + mykeynumber);
		mymanager.MousePressed (mykeynumber);

	}

	void
}
