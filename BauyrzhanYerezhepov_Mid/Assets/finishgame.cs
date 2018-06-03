using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishgame : MonoBehaviour {

		

		void OnTriggerEnter(Collider col){
			Destroy (this.gameObject);
			Time.timeScale = 0;

		}

}


