using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarData : MonoBehaviour
{
    public string data;
    [SerializeField] FormObject form;

    public void CollectData()
    {
        //data = JsonUtility.ToJson(AvatarCustomizer.avatarDataDictionary);
        data = Newtonsoft.Json.JsonConvert.SerializeObject(AvatarCustomizer.avatarDataDictionary);
    }

    public void SendData()
    {
        StartCoroutine(form.Post(data));
    }
}
