using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_4_1_gameManager : MonoBehaviour {

    GameObject objButton;
    public List<GameObject> arrayObject;
    public int arraySize;

	// Use this for initialization
	void Start () {
        GameObject faceButtons = GameObject.Find("UIGrid");
        for(int i =0; i < faceButtons.transform.childCount; i++)
        {
            arrayObject.Add(faceButtons.transform.GetChild(i).gameObject);
            Debug.Log(arrayObject[i].name);
            arrayObject[i].transform.GetChild(0).gameObject.transform.localScale = new Vector3(150, 150, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
