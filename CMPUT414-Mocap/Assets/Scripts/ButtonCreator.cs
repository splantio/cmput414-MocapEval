using UnityEngine;

// Place this script on the content panels that will host file names
public class ButtonCreator : MonoBehaviour {

	private FileNames fN;
    public string modelTag;
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectsWithTag(modelTag)[0];
		fN = new FileNames ();
		for (int i = 0; i < fN.fileString.Count;  i++) {
			GameObject btn = Instantiate (Resources.Load ("Prefab/Button"),gameObject.transform) as GameObject;
            btn.transform.SetParent(transform);
			ButtonControl btnControl = btn.GetComponent<ButtonControl> ();
            btnControl.setFbxFile (fN.fileString [i]);
            btnControl.setCreator(this);
        }
	}

    public GameObject getPlayer()
    {
        return this.player;
    }

    public void setPlayer(GameObject model)
    {
        this.player = model;
    }
}
