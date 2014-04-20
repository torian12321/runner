using UnityEngine;
using System.Collections;

public class FollowCharacter : MonoBehaviour {

	public Transform character;
	public float margin = 7.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(character.position.x + margin, transform.position.y, transform.position.z);
	}
}
