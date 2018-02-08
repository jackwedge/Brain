using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youaretrapped : MonoBehaviour {
	public GameObject forklift;
	public walkcycle bubbleman;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col){

		Debug.Log ("a");
		if(col.gameObject.GetComponent<walkcycle>() == bubbleman)
		{
			Debug.Log ("areuworking");
			Destroy(col.gameObject);
			forklift.gameObject.SetActive (true);

			MAINCAMERA.Me.state = 5;
//			MAINCAMERA.Me.t;

		



		}
	}
}
