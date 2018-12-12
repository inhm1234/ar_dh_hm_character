using UnityEngine;
using System.Collections;

public class s_2_dataLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DataManager.Instance.LoadPlayerInfo();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
