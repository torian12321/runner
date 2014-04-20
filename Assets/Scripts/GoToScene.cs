using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {

	public string SceneName = "GameScene";

	void OnMouseDown(){
		Camera.main.audio.Stop();
		audio.Play();
		Invoke("OpenScene", audio.clip.length);
	}

	void OpenScene(){
		Application.LoadLevel(SceneName);
	}
}
