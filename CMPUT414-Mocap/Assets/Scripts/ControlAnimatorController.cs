using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimatorController : MonoBehaviour {

    public GameObject model;
    private Animator animator;
	// Use this for initialization
	void Start () {
        this.animator = model.GetComponent<Animator>();
        //this.animator.co
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
