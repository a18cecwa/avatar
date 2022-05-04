using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/FormObject", order = 1)]
public class FormObject : ScriptableObject
{
    public string url;
    public string entryId;

    public IEnumerator Post(string data)
    {
        WWWForm form = new WWWForm();
        form.AddField(entryId, data);

        UnityWebRequest www = UnityWebRequest.Post(url, form);

        yield return www.SendWebRequest();
    }
}