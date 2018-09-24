using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCTRL : MonoBehaviour {
//	public Transform pos,pos2;
//	public GameObject[] positionsR;
//	public GameObject[] positions;
	public static GameCTRL instance; 
//	public bool isBlue;
	public GameObject[] x;
	public static bool isAllow;
	public static int index;
	public static int index1;
	public GameObject[,] positions;
	public GameObject blueBead;
	public string name;
	public bool isSit;

	void Awake(){
		index = 1;
		index1 = 1;
		if(instance==null){
			instance = this;
		}
		isAllow = true;
		//pos = transform;
	}
	void Start(){
		
		isSit = false;

		//GameObject x = Instantiate( blueBead,transform.position,Quaternion.identity);
		for(int i=0;i<7;i++){
			for(int j=0;j<7;j++){
				positions [i, j] = (GameObject)Instantiate( blueBead,transform.position,Quaternion.identity);


			}	
		}
	}
	// Use this for initialization
	void Update (){
		if (isSit) {
			if (positions [0, 0].gameObject.tag == positions [0, 1].gameObject.tag &&
				positions [0, 0].gameObject.tag == positions [0, 2].gameObject.tag ||
				positions [0,0].gameObject.tag == positions [3,0].gameObject.tag && 
				positions [0,0].gameObject .tag == positions[6,0].gameObject.tag) {
				print ("hi");
			}
		}
}

}
		//if( positionCTRL.instance.li [i].gameObject.tag == "Blue") {
			//
		
		//	print (positionCTRL.instance.position [0] [0]);



//		for (int i = 0; i < positionCTRL.instance.li.Count; i++) {
//			if (positionCTRL.instance.li [i].gameObject.transform.position == x [0].gameObject.transform.position &&
//			    positionCTRL.instance.li [1].gameObject.transform.position == x [1].gameObject.transform.position &&
//			    positionCTRL.instance.li [1].gameObject.transform.position == x [2].gameObject.transform.position) {
//				print ("sssssssssss");
//			}
//
//			
		
//		if(isBlue){
//			positionsR [0].gameObject.transform.position = pos.position;
//			isBlue = false;
//		}else if(!isBlue){
//			positionsB [0].gameObject.transform.position = pos2.position;
//			isBlue = true;
//		}
	


	
