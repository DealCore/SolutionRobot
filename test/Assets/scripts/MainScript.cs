using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainScript : MonoBehaviour {
	
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();

	}

	void Update()
	{
		
		if (Input.touchCount > 0) {
			anim.Play ("Emergence");
		}
	
	}
}
