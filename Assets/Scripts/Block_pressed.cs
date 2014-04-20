using UnityEngine;
using System.Collections;

public class Block_pressed : MonoBehaviour {

	private bool collisioned = false;
	public int pointsValue = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D collision){
		if(!collisioned && collision.gameObject.tag == "Player"){
			collisioned = true;
			GameObject obj = collision.contacts[0].collider.gameObject;
			if(obj.name=="footLeft_B" || obj.name =="footRight_B"){
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementPoints", pointsValue);
			}			
		}
	}
}
