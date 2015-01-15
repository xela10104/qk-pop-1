﻿using UnityEngine;
using System.Collections;

/*!
 *	Designates a single point in a sidle chain
 */
[RequireComponent (typeof(SphereCollider))]
public class SidlePoint : Placeholder
{
	[SerializeField]
	private GameObject leftDestination;		/*!<GameObject with a SidlePoint component. Leave null if no left destination. */
	[SerializeField]
	private GameObject rightDestination;	/*!<GameObject with a SidlePoint component. Leave null if no right destination. */
	#pragma warning disable 0414
	[SerializeField]
	private bool startPoint = true;			/*!<Toggle true if this point is a point which the player can start/stop sidling. \todo can you stop sidling mid way? */
	#pragma warning restore 0414

#if UNITY_EDITOR
	//! Unity Start function. Used to error check
	void Start(){
		if(leftDestination && leftDestination.GetComponent<SidlePoint>() == false)
			Log.E("safety", "SidlePoint located at " + leftDestination.transform.position + "has invalid leftDestination;");
		if(rightDestination && rightDestination.GetComponent<SidlePoint>() == false)
			Log.E("safety", "SidlePoint located at " + rightDestination.transform.position + "has invalid rightDestination;");
	}
#endif

	void OnDrawGizmos()
	{
		//Gizmos.DrawIcon(transform.position, "sidleGizmo.png");
	}
}
