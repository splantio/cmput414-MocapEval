using UnityEngine.UI;
using UnityEngine;

public class ButtonControl : MonoBehaviour {
	
	private string fbxFile;
    private GameObject player;
    private PlayerAnimator pA;
    private ButtonCreator creator;

    // Use this for initialization
    void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick()
	{
		this.pA.setAnimation(fbxFile);
        this.player.transform.position = new Vector3(0, 0, 0);
    }

	public void setFbxFile(string fileName){
		this.fbxFile = fileName;
		gameObject.GetComponentInChildren<Text>().text = this.fbxFile;
	}
    
    public void setCreator(ButtonCreator bc)
    {
        this.creator = bc;
        this.player = this.creator.getPlayer();
        this.pA = player.GetComponent<PlayerAnimator>();
    }
}
