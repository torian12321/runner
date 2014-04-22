using UnityEngine;
using System.Collections;

public class BG_scroll : MonoBehaviour {

	public float velocity = 0f;
	private bool onMovement = false;
	private float onMovement_iniTime = 0f;
	public bool Camera_AutoMove = false;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver (this, "startToRun");
		NotificationCenter.DefaultCenter().AddObserver (this, "gameOver");
		if(Camera_AutoMove){
			startToRun();
		}
	}

	void startToRun(){
		onMovement = true;
		onMovement_iniTime = Time.time;
	}
	void gameOver(){
		onMovement = false;
	}
	// Update is called once per frame
	void Update () {
//		renderer.material.MainTextureOffset = new Vector2(Time.time * velocity, 0);
		if(onMovement){
			renderer.material.mainTextureOffset = new Vector2(((Time.time - onMovement_iniTime) * velocity)%1, 0);
	
		}
	}
}
