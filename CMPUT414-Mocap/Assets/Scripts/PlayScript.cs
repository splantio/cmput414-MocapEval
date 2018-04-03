using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayScript : MonoBehaviour {

	public Button btn;
	public string fbxFile;
	public bool pause;

	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		pause = false;
	}

	// Update is called once per frame
	void TaskOnClick()
	{
		//test
		pause = !pause;
		if (pause) {
			btn.GetComponentInChildren<Text> ().text = "Play";
			Time.timeScale = 0;
		} else {
			btn.GetComponentInChildren<Text> ().text = "Pause";
			Time.timeScale = 1;
		}

	}
}
