using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WorldPauseButton : MonoBehaviour {

    public Button btn;
    private PlayerAnimator pA1;
    public GameObject player1;
    private PlayerAnimator pA2;
    public GameObject player2;
    public string fbxFile;
    public bool pause;

    // Use this for initialization
    void Start()
    {
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
            pA1.playAnimation();
            pA2.playAnimation();
            player1.transform.position = new Vector3(0, 0, 0);
            player2.transform.position = new Vector3(0, 0, 0);
            //Time.timeScale = 0;
            //pA1.pauseAnimation();
        }
        else
        {
            pA1.pauseAnimation();
            pA2.pauseAnimation();
            //Time.timeScale = 1;
            //pA1.playAnimation();
        }

    }
}
