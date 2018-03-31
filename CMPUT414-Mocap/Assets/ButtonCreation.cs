using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCreation : MonoBehaviour {
	public FileNames fN;
	public PlayerAnimator pA;
	// Use this for initialization
	void Start () {
		fN = new FileNames ();
		for (int i = 0; i < fN.fileString.Count;  i++) {
			//Create the number of buttons for the number of files avilable 
			GameObject bttn = Instantiate (Resources.Load ("Prefab/Button"),gameObject.transform) as GameObject; 
			//bttn.transform.parent = gameObject.transform;
			ButtonScript bttnScript = bttn.GetComponent<ButtonScript> ();
			bttnScript.setFbxFile (fN.fileString [i]);
			//bttnScript.setPlayerAnimator (pA);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
