using UnityEngine;
using System.Collections;

public class Fuel4 : MonoBehaviour {

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
			endObject.GetComponent<EndGame> ().setFuel4(true);
            Assets.VRBike.AchievementManager.collectedFuelCell();
            Destroy (transform.gameObject);
		}
	}
}
