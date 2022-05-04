using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarData : MonoBehaviour
{
    public string data;
    public SheetsHandler sheetsHandler;

    public void CollectData()
    {
        //data = JsonUtility.ToJson(AvatarCustomizer.avatarDataDictionary);
        data = Newtonsoft.Json.JsonConvert.SerializeObject(AvatarCustomizer.avatarDataDictionary);
    }

    public void SendData()
    {
        sheetsHandler.SendText(data);
    }
}
