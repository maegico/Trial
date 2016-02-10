using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float moveSpeed = 10f;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float horizontalVelocity = h * moveSpeed * Time.deltaTime;

        float p = Input.GetAxis("Vertical");
        float verticalVelocity = p * moveSpeed * Time.deltaTime;

        Vector3 velocity = new Vector3(horizontalVelocity, verticalVelocity, moveSpeed * Time.deltaTime);

        transform.Translate(velocity);

        if (Input.GetButtonDown("Fire1"))
            Shoot();
	}

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
