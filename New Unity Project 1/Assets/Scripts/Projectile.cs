using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float projectileSpeed = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalVel = projectileSpeed * Time.deltaTime;
        transform.Translate(horizontalVel, 0, 0);
	}
}
