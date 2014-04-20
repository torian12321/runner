using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			//Debug.Break();
			NotificationCenter.DefaultCenter().PostNotification(this, "gameOver");
			GameObject character = GameObject.Find ("raccoon");
//			Destroy(character);
			character.SetActive (false);
		}else{
			Destroy(other.gameObject);
		}
	}
}
