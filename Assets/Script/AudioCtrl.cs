using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour {
	
	public static AudioCtrl instance;
	public AudioFX audiofx;
	public bool soundOn;
	public bool bgMusicOn;
	public GameObject bgMusic;
	public Transform bead;

	// Use this for initialization

		
	void Start () {
			if (instance == null){
				instance = this;
		}

		if (bgMusicOn) {
			bgMusic.gameObject.SetActive (true);
		}
	}

//	public void SelectBead(Vector3 beadpos){
//		if (soundOn) {
//			AudioSource.PlayClipAtPoint ();
//		}
//

//	}

}