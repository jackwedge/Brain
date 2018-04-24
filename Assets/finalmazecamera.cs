using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalmazecamera : MonoBehaviour {

	public GameObject button;

	public Vector3 centerbraincolorposition;
	public Vector3 centerbrainblackandwhilerposition;
	public Vector3 bigbrainrposition;
	public Vector3 myskinisunravelingrposition;
	public Vector3 skeletonfallsoverrposition;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;

	public AudioSource finalmazesource;
	public AudioClip finalmazeclip;

	public GameObject entirebrain;

	public int state = 0;


	public bool bigbrainactive=true;


	// Use this for initialization
	void Start () {
		bigbrainactive = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)){
			entirebrain.SetActive(!entirebrain.activeSelf);



		}





		if (state == 0) {
			transform.position = bigbrainrposition;

			if (!finalmazesource.isPlaying) {
				finalmazesource.PlayOneShot (finalmazeclip);
			}
	}



		transform.position=bubblemantraveling.position;
		transform.position=new Vector3(	transform.position.x,transform.position.y,-10);

	}


	void hideshowButton() //This is where all the hint button stuff works, If you want to make changes it will be in here
	{
		if (transform.position == bigbrainrposition  ) //add new locations here for hide show button
		{
			button.gameObject.SetActive(true); //when this scene is up, show the button
		}
		else
		{
			button.gameObject.SetActive(false);
		}
	}


}
