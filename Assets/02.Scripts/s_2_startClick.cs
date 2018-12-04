using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class s_2_startClick : MonoBehaviour {

    private UISprite m_Fade;
    public float m_fDuration = 3f;
    private GameObject gobject;

    private UISprite _sprite;

    private void Awake()
    {
        _sprite = GetComponent<UISprite>();
    }
    private void Start()
    {
        gobject = GameObject.Find("FadeObject");
    }
    void OnClick()
    {
//        _sprite.color = new Color(Random.value, Random.value, Random.value);
        gobject.SetActive(true);
        m_Fade = GameObject.Find("FadeObject").GetComponent<UISprite>();
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration, 1f);
        yield return new WaitForSeconds(m_fDuration);

        NextSceneCall();
    }

    void NextSceneCall()
    {
        SceneManager.LoadScene("S_3_Gallery");
    }
}
