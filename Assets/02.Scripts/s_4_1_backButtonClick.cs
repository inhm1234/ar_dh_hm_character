using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class s_4_1_backButtonClick : MonoBehaviour
{
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
        StartCoroutine(BackScene());
    }
    IEnumerator BackScene()
    {
        yield return new WaitForSeconds(0);

        GameManager.Instance.ChangeScene("S_4_makePerson");
    }
}
