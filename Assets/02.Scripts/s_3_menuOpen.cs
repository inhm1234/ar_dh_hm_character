using UnityEngine;
using System.Collections;

public class s_3_menuOpen : MonoBehaviour {

    Animator animator;
    private GameObject gobject;
    // Use this for initialization
    void Start () {

        gobject = GameObject.Find("MenuScene");
        animator = gobject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnPress()
    {
        animator.SetInteger("menustate", 1);
    }
 //   void OnClick()
 //   {
 //       //        _sprite.color = new Color(Random.value, Random.value, Random.value);
 //       //        gobject.SetActive(true);
 //       //        StartCoroutine(FadeOut());
 //       animator.SetInteger("menustate", 1);
 //
 //   }
}
