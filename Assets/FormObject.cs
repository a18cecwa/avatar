using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


/// <summary>
/// Scriptable Object to represent a Form.
/// Based on: https://www.youtube.com/watch?v=2-tUwIQmBNE
/// See video for instructions about how to find the correct values for url and entryId.
/// </summary>

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/FormObject", order = 1)]
public class FormObject : ScriptableObject
{
    [SerializeField] string url;
    [SerializeField] string entryId;
    [SerializeField] string keys;

    Dictionary<string, string> data = new Dictionary<string, string>();

    public IEnumerator Post(string data)
    {
        WWWForm form = new WWWForm();
        form.AddField(entryId, data);

        UnityWebRequest www = UnityWebRequest.Post(url, form);

        yield return www.SendWebRequest();
    }

    public IEnumerator Post()
    {
        yield return Post(Newtonsoft.Json.JsonConvert.SerializeObject(data));
    }

    public void Set(string key, string value)
    {
        if (data.ContainsKey(key))
            data[key] = value; // Is this neccessary or does Dictionary.Add already work like this?
        else
            data.Add(key, value);
    }

    public void Clear()
    {
        data.Clear();
    }
}