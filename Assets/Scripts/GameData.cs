using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameData : MonoBehaviour {
	public int maxPoints=0;
	public static GameData gameData;
	private String fileRoot;

	void Awake(){
		fileRoot= Application.persistentDataPath + "/gameData.dat";

		if(gameData == null){
			gameData = this;
			DontDestroyOnLoad(gameObject);
		}else if(gameData!=this){
			Destroy(gameObject);
		}

	}

	// Use this for initialization
	void Start () {
		Load();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Save(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(fileRoot);
		DataToSave DTS = new DataToSave();
		DTS.puntuation_Max = maxPoints;

		bf.Serialize(file, DTS);
		file.Close();

	}
	void Load(){
		if(File.Exists(fileRoot)){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(fileRoot, FileMode.Open);
			DataToSave DTS = (DataToSave) bf.Deserialize(file);

			maxPoints = DTS.puntuation_Max;
			
			bf.Serialize(file, DTS);
			file.Close();
		}else{
			maxPoints=0;
		}
	}
}

[Serializable]
class DataToSave{
	public int puntuation_Max;

	/*public DataToSave(int puntuation_Max){
		this.puntuation_Max = puntuation_Max;
	}*/
}