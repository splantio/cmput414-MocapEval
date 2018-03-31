using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour {
	private Text feild;
	public FileNames fN;

	// Use this for initialization
	void Start () {
		feild = GetComponent<Text>();
		fN = new FileNames ();
		feild.text = fN.fileString[0];
		print (fN.fileString);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
