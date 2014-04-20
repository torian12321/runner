using UnityEngine;
using System.Collections;

public class GameOver_values : MonoBehaviour {

	public TextMesh total;
	public TextMesh record;
	public Puntuation points;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable(){
		total.text = points.points.ToString();
		if (GameData.gameData != null){
			if(GameData.gameData.maxPoints > points.points){
				record.text = GameData.gameData.maxPoints.ToString();
			}else{
				record.text = points.points.ToString();
			}
		}
	}
}
