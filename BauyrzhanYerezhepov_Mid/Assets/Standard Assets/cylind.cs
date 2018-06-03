using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cylind : MonoBehaviour {
	public float moveSpeed;
	public Text countText;
	private int count;
	// Use this for initialization
	void Start () {
		moveSpeed = 10f;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
	}
	void OnTriggerEnter(Collider col){
		
		count = count + 1;
		SetCountText ();
		if (col.gameObject.CompareTag ("finish")) {
			PrintScore ();

		}
	}
	void SetCountText(){
		print ("Count: "+count);
	}
	void PrintScore(){
		print ("Final Score: "+count);
	}

}
