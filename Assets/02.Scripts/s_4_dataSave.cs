using UnityEngine;
using System.Collections;

public class s_4_dataSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void testSave()
    {
            DataManager.Instance.SavePlayerInfo();
            Debug.Log("Save_OK");   
    }
}
