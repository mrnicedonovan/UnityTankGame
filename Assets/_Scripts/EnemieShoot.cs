using UnityEngine;
using System.Collections;

public class EnemieShoot : MonoBehaviour {

	private float reloadTime;
	public float timeReload;
	public GameObject bulletPrefab;
	public  float shootRange;
	private Transform Turret;
	private Transform Nozzle;


	// Use this for initialization
	void Start () {
		reloadTime = 0;

		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms) {
		if(t.gameObject.name == "Turret")
			{
				Turret = t;
			}
		if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t;
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeReload)
		{
			PlayerCheck();
		}
	
	}
	private void PlayerCheck()
	{
		Ray myRay = new Ray ();
		myRay.origin = Turret.position;
		myRay.direction = Turret.forward;

		RaycastHit hitInfo;

		if(Physics.Raycast(myRay, out hitInfo,shootRange))
		{
			//print("De Raycast ZIET!");
			string hitObjectName = hitInfo.collider.gameObject.name;
		
			if(hitObjectName == "TankPlayer")
			{
				Instantiate(bulletPrefab,Nozzle.position,Nozzle.rotation);

				reloadTime = 0;
			
			}
		}

	}

}
