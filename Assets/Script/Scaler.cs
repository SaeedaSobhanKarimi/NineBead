using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaler : MonoBehaviour {
	//public SpriteRenderer randarer;
	//public Image img;
	Color  tempcolor;
	bool isSelect;
	static bool isSelectOne;
//	public string [][] locations;
	public RaycastHit2D hit;
	// Use this for initialization
	public static Scaler instance;
	void Awake(){
		if (instance == null)
			instance = this;
	}
	void Start () {
	//	locations[0][0]="Full";
	//	isSelectOne = true;
	//	randarer = GetComponent<SpriteRenderer> ();
		isSelect = false;

	//	 tempcolor=randarer.color;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mouseX = new Vector2 (mousPos.x,mousPos.y);
			hit = Physics2D.Raycast (mouseX,Vector2.zero);

			if (hit.collider != null) {
				print (hit.transform.name+"ss");
			}
		}

		
	} 
	void DeSelect(){ 
		tempcolor.a = 1f;
	//	randarer.color = tempcolor;
		isSelect = false;
		//isSelectOne = false;
	}
	void Select(){
		tempcolor.a=0.5f;
	//	randarer.color = tempcolor;
		isSelect = true;
		FindObjectOfType<Move> ().enabled = true;
		//FindObjectOfType<Scaler> ().enabled = true;

	}
	void OnMouseDown (){
		//GameObject.Find ();
//		if (isSelect) {
//	  if(gameObject.CompareTag("Blue")){
//		  DeSelect ();
//		} else {
//
//				Select ();
//			}
//
//				
//	}else if (!isSelect){
//			if(gameObject.CompareTag("Orange")){
//				DeSelect ();
//			} else {
//
//				Select ();
//			}
//
//				}
//
//		}
	}}

