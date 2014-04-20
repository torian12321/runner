using UnityEngine;
using System.Collections;

public class Puntuation : MonoBehaviour {

	public int points = 0;
	public TextMesh score;
	//public static GameData gameData;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver(this, "IncrementPoints");
		NotificationCenter.DefaultCenter ().AddObserver(this, "gameOver");
	}
	void IncrementPoints (Notification notification){
		int cuantity = (int)notification.data;
		points+=cuantity;
		score.text = points.ToString();
	}
	void gameOver (Notification notification){
		//maxPoints
		if(points > GameData.gameData.maxPoints){
			GameData.gameData.maxPoints = points;
			GameData.gameData.Save();
		}else{
		}
	}
}
