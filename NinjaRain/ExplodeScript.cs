﻿using UnityEngine;
using System.Collections;

public class ExplodeScript : MonoBehaviour {
	private ParticleSystem ps;

	public void Start() 
	{
		ps = GetComponent<ParticleSystem>();
	}
	
	public void Update() 
	{
		if(ps && !ps.IsAlive())
		{
			Destroy(gameObject);
		}
	}
}