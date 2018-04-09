using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WorldPauseButton : MonoBehaviour {

    public Button btn;
    public PlayerAnimator pA1;
    public GameObject player1;
    public PlayerAnimator pA2;
    public GameObject player2;
    public string fbxFile;
    public bool pause;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("human");
        player2 = GameObject.FindGameObjectWithTag("human2");
        pA1 = player1.GetComponent<PlayerAnimator>();
        pA2 = player2.GetComponent<PlayerAnimator>();
        btn.onClick.AddListener(TaskOnClick);
        pause = false;
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("test");
        //test
        pause = !pause;
        if (pause)
        {
            btn.GetComponentInChildren<Text>().text = "Play (both)";
            Time.timeScale = 0;
            //pA1.pauseAnimation();
        }
        else
        {
            btn.GetComponentInChildren<Text>().text = "Pause (both)";
            Time.timeScale = 1;
            //pA1.playAnimation();
        }

    }
}
