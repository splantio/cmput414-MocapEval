using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayScript2 : MonoBehaviour {

	public Button btn;
    public PlayerAnimator pA;
    public GameObject player;
    public string fbxFile;
	public bool pause;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("human2");
        pA = player.GetComponent<PlayerAnimator>();
        //yerAnimator)) as PlayerAnimator;
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
            pA.pauseAnimation();
		} else {
			btn.GetComponentInChildren<Text> ().text = "Pause";
            pA.playAnimation();
		}

	}
}
