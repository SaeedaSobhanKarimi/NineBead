using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionCTRL : MonoBehaviour {
	public static positionCTRL instance; 
			public int row;
			public int column;
			public GameObject blueBead;
			public bool chosses;
            public List<GameObject> li;
			public static int k;
	void Awake(){
		
		if(instance==null){
			instance = this;
		}
	//	positions = new GameObject[10,10];
		k = 0;
		//pos = transform;
	}
			//Vector3 nextposblue,nextposred;

			public GameObject redBead;
			public static bool isRed;	
			// Use this for initialization
			void Start () {
		GameCTRL.instance.positions = new GameObject[7,7];
		//GetComponent<Move> ().enabled = false;
		//nextposblue = blueBead.transform.position;
		//nextposred =  redBead.transform.position;
			chosses = true;
			isRed = true;
		}
	void Update(){
		

	}
	
	
// Update is called once per frame
	

			void OnMouseDown(){
		row = gameObject.name [0];
		column = gameObject.name [2];

		GetComponent<BoxCollider2D> ().enabled = false;

		if (chosses && isRed) {
			//GameCTRL.instance.pos = gameObject.transform;

			Vector3 x = Input.mousePosition;
			//transform.position = Vector3.Lerp (nextposred,nextposblue,2);


			Vector3 w = new Vector3 (transform.position.x, transform.position.y, 5);


			if (GameCTRL.index <= 9) {

				GameObject be =  Instantiate (redBead, w, Quaternion.identity);
				//GameCTRL.instance.positions[row,column]=be;
				GameCTRL.instance.isSit=false;

				be.AddComponent<Draggable> ();
				li.Add (be);
				chosses = false;	
				isRed = false;
//				positions [0,0] = be;
//				print (positions [0,0]);

				k++;
				GameCTRL.index++;
 				//GetComponent<Draggable> ().enabled = false;
				GetComponent<positionCTRL> ().enabled = false;
			}
		}
		
			else if(chosses && !isRed){
			//GameCTRL.instance.pos2 = gameObject.transform;

			Vector3 x = Input.mousePosition;

			Vector3 w = new Vector3 (transform.position.x-0.5f,transform.position.y+0.5f,5);
			if (GameCTRL.index1 <= 9) {
				chosses = false;
				GameCTRL.instance.isSit = false;
				GameObject be = Instantiate (blueBead, w, Quaternion.identity);
				li.Add (be);
//				positions [0,1] = be;
//				print (positions [0,1]);

				k++;
				isRed = true;
				GameCTRL.index1++;
				//GetComponent<Draggable> ().enabled = false;
				GetComponent<positionCTRL> ().enabled = false;
// 			checkMove ();
			}

		}

		}

//	void checkMove(){
//		if (positionCTRL.instance.positions [0, 0].gameObject.tag == positionCTRL.instance.positions [0, 1].gameObject.tag) {
//			print ("Ok");
//		} else {
//			print ("No");
//		}
//	}
}
		






			



