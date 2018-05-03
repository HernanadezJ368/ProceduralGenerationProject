using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSpawner : MonoBehaviour {

	public int Door;

	private Prefabs roomBlocks;
	private int randomblock;
	private bool FilledSpot = false;
	public static Text countbox;
	public static int roomcount = 1;
	public static int deletecount = 0;

	void Start(){
		roomBlocks = GameObject.FindGameObjectWithTag("rooms").GetComponent<Prefabs> ();
		Invoke ("spawn", 0.10f);
	}
	void Update(){
	}

	void spawn(){
		if (FilledSpot == false) {
			if (Door == 3) {
				randomblock = Random.Range(0,roomBlocks.OpenTop.Length);
				Instantiate (roomBlocks.OpenTop [randomblock], transform.position, roomBlocks.OpenTop [randomblock].transform.rotation);
				if (randomblock == roomBlocks.OpenTop.Length) {
					Instantiate (roomBlocks.Block, transform.position,Quaternion.identity);
				}
			} 
			else if (Door == 4) {
				randomblock = Random.Range(0,roomBlocks.OpenRight.Length);
				Instantiate (roomBlocks.OpenRight [randomblock], transform.position, roomBlocks.OpenRight [randomblock].transform.rotation);
				if (randomblock == roomBlocks.OpenRight.Length) {
					Instantiate (roomBlocks.Block, transform.position,Quaternion.identity);
				}
			}
			else if (Door == 1) {
				randomblock = Random.Range(0,roomBlocks.OpenBottom.Length);
				Instantiate (roomBlocks.OpenBottom [randomblock], transform.position, roomBlocks.OpenBottom [randomblock].transform.rotation);
				if (randomblock == roomBlocks.OpenBottom.Length) {
					Instantiate (roomBlocks.Block, transform.position,Quaternion.identity);
				}
			}
			else if (Door == 2) {
				randomblock = Random.Range(0,roomBlocks.OpenLeft.Length);
				Instantiate (roomBlocks.OpenLeft [randomblock], transform.position, roomBlocks.OpenLeft [randomblock].transform.rotation);
				if (randomblock == roomBlocks.OpenLeft.Length) {
					Instantiate (roomBlocks.Block, transform.position,Quaternion.identity);
				}

			}
			roomcount += 1;
			FilledSpot = true;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("SpawnPoint") && other.GetComponent<RoomSpawner>().FilledSpot == true) {
				Destroy (gameObject);
			deletecount += 1;
			}
		}
}

