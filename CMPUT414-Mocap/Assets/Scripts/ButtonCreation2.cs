using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCreation2 : MonoBehaviour {
	public FileNames fN;
	public PlayerAnimator pA;
    public Transform contentPanel;
	// Use this for initialization
	void Start () {
		fN = new FileNames ();
		for (int i = 0; i < fN.fileString.Count;  i++) {
			//Create the number of buttons for the number of files avilable 
			GameObject bttn = Instantiate (Resources.Load ("Prefab/Button2"),gameObject.transform) as GameObject;

            bttn.transform.SetParent(contentPanel);
			ButtonScript2 bttnScript = bttn.GetComponent<ButtonScript2> ();
			bttnScript.setFbxFile (fN.fileString [i]);
            bttnScript.setPlayerAnimator(pA);
			//bttnScript.setPlayerAnimator (pA);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
