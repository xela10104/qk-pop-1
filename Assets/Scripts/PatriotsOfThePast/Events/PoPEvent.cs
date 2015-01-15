﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SphereCollider))]
public class PoPEvent : Placeholder
{
	#pragma warning disable 0414
	[SerializeField]
	private string prerequisite = "";	/*!<this string is for to check for a completed pre-requisite quest */

	//other prerequsite (eg: item count, time, %map explored, etc.) need a system to be made
	[SerializeField]
	private string
		quest = ""; //if this event will start a quest
	[SerializeField]
	private Vector3
		cameraPos, lookAtPos; //camera position for event

	public void BeginEvent()
	{
		//camera movements
		/*
         * Camera movements need to have a line segment (two nodes) that dictate where the camera (position) and where it looks at (rotation)
         * Further effects would be to give the camera simple movement functionality (GoKit)
         */
		//Prep dialogue code, text + input (next/skip)
		//at the end of the dialogue, activate quest (in dailogue function)
	}

	void OnDrawGizmos()
	{
		//Gizmos.DrawIcon(transform.position, "eventGizmo.png");
		Gizmos.color = Color.yellow / 3;
		// Draw a yellow sphere at the transform's position
		if (GetComponent<SphereCollider>()) {
			Gizmos.DrawSphere(transform.position, this.GetComponent<SphereCollider>().radius);
		}
	}
}
