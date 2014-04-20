using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject[] obj;
	public float timeMin = 1.5f;
	public float timeMax = 2.5f;
	private bool end = false;
	// Use this for initialization

	void Start () {
		//Generate();
		NotificationCenter.DefaultCenter().AddObserver (this, "startToRun");
		NotificationCenter.DefaultCenter().AddObserver (this, "gameOver");
	}
	private void startToRun(Notification notification){
		Generate();
	}
	private void gameOver(){
		end = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generate(){
		if(!end){
			Instantiate (obj[Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
			Invoke("Generate", Random.Range (timeMin, timeMax));
		}
	}
}
