﻿using UnityEngine;
using System.Collections;

public class ParticleSystemDeath : MonoBehaviour {

	public ParticleSystem destructionEffect;
	private bool isQuitting;
	// Use this for initialization
	void Start () {
		isQuitting = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnApplicationQuit(){
		isQuitting = true;
	}
	public void OnDeath(){
		Instantiate (destructionEffect, this.transform.position,destructionEffect.transform.rotation);
        Destroy(this.gameObject);
	}
}
