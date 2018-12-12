using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroClick : MonoBehaviour {

    private UISprite m_Fade;
    public float m_fDuration = 3f;

    void Start()
    {
        m_Fade = GameObject.Find("FadeObject").GetComponent<UISprite>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        TweenAlpha.Begin(m_Fade.gameObject,m_fDuration, 0f);
        yield return new WaitForSeconds(m_fDuration);

        TweenAlpha.Begin(m_Fade.gameObject,m_fDuration, 1f);
        yield return new WaitForSeconds(m_fDuration);

        GameManager.Instance.ChangeScene("S_2_GameStart");
    }
}
