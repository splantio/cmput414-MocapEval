using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayScript2 : MonoBehaviour {

	public Button btn;
    public PlayerAnimator pA;
    public GameObject player;
    public string fbxFile;
    private bool paused;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("human2");
        pA = player.GetComponent<PlayerAnimator>();
		btn.onClick.AddListener(TaskOnClick);
        this.paused = false;
    }


    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("Clicked play button");
        //btn.GetComponentInChildren<Text> ().text = "Play";
        if (!paused)
        {
            pA.pauseAnimation();
        }
        else {
            //btn.GetComponentInChildren<Text> ().text = "Pause";
            pA.playAnimation();
        }

        paused = !paused;

    }
}
