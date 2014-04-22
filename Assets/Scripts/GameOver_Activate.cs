using UnityEngine;
using System.Collections;

public class GameOver_Activate : MonoBehaviour {

	public GameObject GO_Camera;
	public AudioClip GO_Sound;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver(this, "gameOver");
	}
	void gameOver(Notification notificacion){
		audio.Stop();
		audio.clip=GO_Sound;
		audio.loop = false;
		audio.Play();
		GO_Camera.SetActive(true);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
