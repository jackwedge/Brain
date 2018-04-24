using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runmygrowtreespritess : MonoBehaviour {

	public SpriteRenderer reincarnationSpriterenderer;
	public Sprite [] mysprites;




	int interval= 0;
	public Vector3 runoutofskullrposition;
	public Vector3 finalfieldrposition;
	public Vector3 treegrowsrposition;
	public Transform bubblemantraveling;
	public Vector3 treegoodbyeposition;

	public Vector3 treeposition;
//	public Camera cam;
	public endingcameracontroller fincamera;


	public AudioClip slidingthruintestinessound;
	public AudioSource slidingthruintestinessource;



	float timer;

	float waittime =0.1f;

//	public int state = 0;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (fincamera.state == 3) {
			if (Input.GetKey (KeyCode.RightArrow) && timer <= 0) {

				if (interval < mysprites.Length) {
					reincarnationSpriterenderer.sprite = mysprites [interval];
					interval++;


//					if (!slidingthruintestinessource.isPlaying) {
//						slidingthruintestinessource.PlayOneShot (slidingthruintestinessound);
//					}


				}

				timer += waittime;

//				if (interval == 190) {
//					fincamera.state == 4;
//
//
//		}


	



//				if (interval >= mysprites.Length) {
//					//interval = mysprites.Length - 1;
//					}
//				}
				
//
//				if (Input.GetKey (KeyCode.LeftArrow) ) {
//
//					if (interval < mysprites.Length) {
//					reincarnationSpriterenderer.sprite = mysprites [interval];
//
//					}
//
//
//
//					interval--;
//
//					if (interval <= 0) {
//						interval = 0;
//					}
//
//				
//
//
//				}





				if (interval == 185) {
					//Debug.Log ("changinglocations");
					SceneManager.LoadScene(0);
			//	MAINCAMERA.reincarnate = true;
				





				}

			}



//			if (Input.GetKeyUp (KeyCode.RightArrow)) {
//				if (slidingthruintestinessource.isPlaying) {
//
//
//					slidingthruintestinessource.clip = slidingthruintestinessound;
//					slidingthruintestinessource.Stop ();
//
//				}
//			}


		}



	
		
}	
}
