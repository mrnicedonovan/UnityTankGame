﻿using UnityEngine;
using System.Collections;

public class ShootBehavior : MonoBehaviour {

	public float speed;
	public float maxLifeTime;
	public float lifeTime = 0f;
	public GameObject exploPrefab;

	// Use this for initialization
	void Start () {	
	
	}
	
	// Update is called once per frame
	void Update () {
		float delta = Time.deltaTime;
		transform.Translate(Vector3.forward * speed * delta);
		lifeTime += delta;
		if(lifeTime > maxLifeTime)
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision coll)
	{
		Instantiate(exploPrefab, this.transform.position, this.transform.rotation);
		
		Destroy(this.gameObject);
	}
}