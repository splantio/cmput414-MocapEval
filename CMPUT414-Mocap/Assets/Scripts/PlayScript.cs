using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

// Attach to the individual play buttons
public class PlayScript : MonoBehaviour {

    public string modelTag;
    private PlayerAnimator pA;
    private GameObject player;
    private bool paused;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag(modelTag);
        pA = player.GetComponent<PlayerAnimator>();
        Button btn = gameObject.GetComponent<Button>().GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        this.paused = false;
	}
    
	public void OnClick()
	{
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
