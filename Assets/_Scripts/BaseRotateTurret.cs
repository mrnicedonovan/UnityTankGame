﻿using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

	private Transform[] transforms;
	protected Transform Turret;
	protected Vector3 targetPos;
	protected Transform Nozzle;


	// Use this for initialization
	protected virtual void Start () {

		bool turretFound = false;

		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach(Transform t in transforms)
		{
			if (t.gameObject.name == "Turret")
			{
				Turret = t;
				turretFound = true;
			}
			if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t;

			}
		}

		if (!turretFound)
		{
			print ("no turret was found in gameObject");
		}
	}
	
	// Update is called once per frame
	protected virtual void Update () {

		Turret.LookAt (targetPos);	
	}
}
