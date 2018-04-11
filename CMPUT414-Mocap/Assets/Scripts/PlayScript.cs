using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

// Attach to the individual play buttons
public class PlayScript : MonoBehaviour {
    
    private PlayerAnimator pA;
    public GameObject player;
    private bool paused;

    // Use this for initialization
    void Start () {
        //player = GameObject.FindGameObjectWithTag("human");
        pA = player.GetComponent<PlayerAnimator>();
        Button btn = gameObject.GetComponent<Button>().GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        print(btn);
        this.paused = false;
	}
    
	public void OnClick()
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
