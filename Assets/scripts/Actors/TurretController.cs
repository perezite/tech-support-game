using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour {

	// projectile prefab
	public GameObject projectilePrefab;

	// rotation speed
	public float omega = 3f;

	// speed of the projectile
	public float speed = 3f;

	// bullet lifetime
	public float bulletLifetime = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
		// rotate turret
		Vector3 r = new Vector3(0f, Input.GetAxis("Turret")*omega, 0f);
		transform.Rotate(r);
		
		// launch projectile
		if (Input.GetButtonDown("Fire1"))
		{
			//Debug.Log("shoot");
			GameObject projectileClone = (GameObject) Instantiate(projectilePrefab, transform.position, transform.rotation);
			projectileClone.rigidbody.velocity = transform.forward * speed;
			Destroy (projectileClone, 5f);
		}
	}
}
