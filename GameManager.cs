using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public Text thebox;
	public Text deletebox;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		string count =  RoomSpawner.roomcount.ToString ();
		string deletecount = RoomSpawner.deletecount.ToString ();
		thebox.text = "Number of Rooms:" + count;
		deletebox.text = "Number of Deleted Rooms:" + deletecount;
	}
}
