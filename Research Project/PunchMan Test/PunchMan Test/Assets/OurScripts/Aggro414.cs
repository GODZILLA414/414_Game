//http://gamedev.stackexchange.com/questions/97265/unity-basic-ai-enemy-follows-player-prevent-flocking-of-enemies-together
//answer.unity3d.com/question/411616/slope-limiting-for-rigidbody.html
using UnityEngine;
using System.Collections;


public class Aggro414 : MonoBehaviour {

	public Transform player;
	public int moveSpeed;
    public int damage;
    public static float health = 100;

    public float playerDistance;
	private PlayerHealth414 playerHealth;
    
	// Use this for initialization
	void Start () {
		GameObject thePlayer = GameObject.Find ("ThirdPersonController");	
		player = GameObject.Find ("ThirdPersonController").transform;
		playerHealth = thePlayer.GetComponent<PlayerHealth414> ();
		// GetComponent<Animation>().Play ("walk");

        moveSpeed += (int)Random.Range(-2f, 2f);
	}

	// Update is called once per frame
	void Update () {
		if (player != null) { // player exists

            RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.forward, out hit, 1.0f)) {
				if (Vector3.Dot (Vector3.up, hit.normal) < 1) { // slope exists
					//print ("slope");
					//transform.Translate(0, -5, -5);
					Physics.gravity = new Vector3 (0, 0, 0);
				}
			} else {
				//print ("no slope");
				Physics.gravity = new Vector3 (0, -9, 0);
			}
			transform.position += (player.position - transform.position).normalized*moveSpeed*Time.deltaTime;
			transform.LookAt (player);
            playerDistance = Vector3.Distance(transform.position, player.position);
		}
	}

	void OnCollisionEnter(Collision col) {
		//print ("collided");
		if (col.gameObject.name == "ThirdPersonController") {
			playerHealth.TakeDamage(damage);
			Destroy (transform.gameObject);
        }
	}
}