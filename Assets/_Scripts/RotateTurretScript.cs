using UnityEngine;
using System.Collections;

public class RotateTurretScript : MonoBehaviour {

	public Camera camera;
	private Transform[] transforms;
	private Transform turret;

	// Use this for initialization
	void Start () {
		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach(Transform t in transforms)
		{
			if (t.gameObject.name == "Turret")
			{
				turret = t;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition; //(x,y,z)
		mousePos.z = camera.transform.position.y - turret.transform.position.y;

		Vector3 worldPos = camera.ScreenToWorldPoint (mousePos);
		turret.LookAt (worldPos);


		//print ("World" + worldPos);
	}
}
