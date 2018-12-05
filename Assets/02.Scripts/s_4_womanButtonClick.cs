using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class s_4_womanButtonClick : MonoBehaviour {

    private UISprite _sprite;

    private void Awake()
    {
        _sprite = GetComponent<UISprite>();
    }
    private void Start()
    {
        //        gobject = GameObject.Find("FadeObject");
    }
    void OnClick()
    {
        //        _sprite.color = new Color(Random.value, Random.value, Random.value);
        //        gobject.SetActive(true);
        //        m_Fade = GameObject.Find("FadeObject").GetComponent<UISprite>();
        StartCoroutine(MakeWoman());
    }
    IEnumerator MakeWoman()
    {
        yield return new WaitForSeconds(0);

        NextSceneCall();
    }

    void NextSceneCall()
    {
        SceneManager.LoadScene("S_4_1_DetailPerson");
    }
}
