using UnityEngine;
using System.Collections;

public class Fuel2 : MonoBehaviour {

	public EndGame end;
	public GameObject endObject;
	// Use this for initialization
	void Start() {
		endObject = GameObject.Find ("End");
	}


	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		//print ("collided");
		if (col.gameObject.name == "ThirdPersonController") {
			print ("Got Fuel 2!");
            Assets.VRBike.AchievementManager.collectedFuelCell();
            endObject.GetComponent<EndGame> ().setFuel2(true);
			Destroy (transform.gameObject);
		}
	}
}
