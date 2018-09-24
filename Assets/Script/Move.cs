using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	GameObject blueBead;
	public float distance = 100f;
	public enum BeadState{
		full,empty
		
	}
	public BeadState state;
	Vector3 pos;

	// Use this for initialization
	//public string [][] locations;

	void Start () 
	{
	//	state = BeadState.empty;
		blueBead = GameObject.Find ("blueBead");

		//locations [0] [0] = "Full";
		//state = BeadState.empty;
		//	if(pos ==bead.empty){

		//		}

		//pos = GameObject.Find ("blueBead").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
//		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.position + transform.right * distance, Mathf.Infinity);
//		if (hit.collider != null)
//		{
//			GameObject x =  GameObject.Find (hit.transform.name);
//			print (x);
//
//
//		}
	}

	void OnMouseDown ()
	{
		
		if (state == BeadState.empty) {
			
			Scaler.instance.hit.transform.position = transform.position;
	
		}

	}
}
	