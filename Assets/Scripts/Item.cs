using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public int pointsValue = 5;
	public AudioClip ItemSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){
			AudioSource.PlayClipAtPoint(ItemSound, Camera.main.transform.position, 1);
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementPoints", pointsValue);
			Destroy(gameObject);
		}
	}
}
