using UnityEngine;
using System.Collections;
using System.Collections.Generic; //리스트를 쓰기위해 추가
using System.IO;
using LitJson;

/*==================================================*/
/* 18.12.07 */
/* 동훈 */
/* 플레이어 정보를 관리하는 클래스  */


/* 플레이어 데이터 저장클래스 */
public class PlayerInfo
{
    public string name_;
    public int scores_;
//    int test1;
//    int test2;
//    int test3;
//    int test4;

//    public PlayerInfo(int a, int b, int c, int d)
//    {
//        test1 = a;
//        test2 = b;
//        test3 = c;
//        test4 = d;
//    }
public PlayerInfo(string name,int scores)
    {
        name_ = name;
        scores_ = scores;
    }
    public void printNumber()
    {
        //        Debug.Log(test1);
        //        Debug.Log(test2);
        //        Debug.Log(test3);
        //        Debug.Log(test4);

        Debug.Log(name_);
        Debug.Log(scores_);
    }
}
[SerializeField]
class Data
{
    public string name;
    public List<string> likes;
    public int level;
}

public class DataManager : MonoBehaviour {

    List<PlayerInfo> playerInfoList = new List<PlayerInfo>();

    private static DataManager sInstance;
    public static DataManager Instance
    {
        get
        {
            if (sInstance == null)
            {
                GameObject newGameObject = new GameObject("_DataManager");
                newGameObject = new GameObject("_DataManager");
                sInstance = newGameObject.AddComponent<DataManager>();
            }

            return sInstance;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        Data data = new global::Data();
        data.name = "형민";
        data.level = 10;
        data.likes = new List<string>()
        {
            "dog","cat"
        };
        Debug.Log(JsonUtility.ToJson(data, prettyPrint: true));
        JsonData infoJson = JsonUtility.ToJson(data, prettyPrint: true);
        File.WriteAllText(Application.dataPath + "/Resources/Data/PlayerInfoData.json", infoJson.ToString());

    }

    public void SavePlayerInfo()
    {
        Debug.Log("SavePlayerInfo");
//        playerInfoList.Add(new PlayerInfo(1, 2, 3, 4));
//        playerInfoList.Add()

        for(int i = 0; i < playerInfoList.Count;i++)
        {
            JsonData infoJson = JsonMapper.ToJson(playerInfoList[i]);
            Debug.Log(infoJson);
            File.WriteAllText(Application.dataPath + "/Resources/Data/PlayerInfoData.json", infoJson.ToString());
        }

        Debug.Log(playerInfoList.Count);
        for(int i =0; i < playerInfoList.Count;i++)
        {
            playerInfoList[i].printNumber();
        }
    }

    public void LoadPlayerInfo()
    {
        Debug.Log("LoadPlayerInfo");
        if (File.Exists(Application.dataPath + "/Resources/Data/PlayerInfoData.json"))
        {

            string jsonStr = File.ReadAllText(Application.dataPath + "/Resources/Data/PlayerInfoData.json");
            Debug.Log(jsonStr);
            JsonData playerData = JsonMapper.ToObject(jsonStr);

            for (int i = 0; i < playerData.Count; i++)
            {
                Debug.Log(playerData.Count);
//                Debug.Log(playerData[i]["test1"].ToString());
            }
        }
  
        else
            Debug.Log("파일이 존재하지 않습니다.");

        for (int i = 0; i < playerInfoList.Count; i++)
        {
            playerInfoList[i].printNumber();
        }
    }
}
