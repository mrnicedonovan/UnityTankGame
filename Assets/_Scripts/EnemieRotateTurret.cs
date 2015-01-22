using UnityEngine;
using System.Collections;

public class EnemieRotateTurret : BaseRotateTurret {

	public Transform player;

	// Update is called once per frame
	override protected void Update () {

		targetPos = player.position;
		base.Update ();
	
	}
}
