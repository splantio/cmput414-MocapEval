using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
	
	public Button btn;
	public string fbxFile;
	public PlayerAnimator pA;
	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		//pA.setAnimation (fbxFile);

	}

	public void setFbxFile(string fileName){
		this.fbxFile = fileName;
		gameObject.GetComponentInChildren<Text>().text = this.fbxFile;
	}

	public void setPlayerAnimator(PlayerAnimator newPA){
		this.pA = newPA;
	}
}
