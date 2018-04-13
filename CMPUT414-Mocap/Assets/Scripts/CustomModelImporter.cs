using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomModelImporter : MonoBehaviour {

    private ModelImporter importer;

	// Use this for initialization
	void Start () {
        Mesh mesh = (Mesh)Resources.Load("Models/Anthony.fbx", typeof(Mesh));
        GameObject newBoy = new GameObject("Figure");
        newBoy.tag = "human";
        newBoy.AddComponent<MeshFilter>();
        newBoy.GetComponent<MeshFilter>().mesh = mesh;
        newBoy.transform.position = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
