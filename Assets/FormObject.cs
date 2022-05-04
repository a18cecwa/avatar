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

    string data;

    public IEnumerator Post(string data)
    {
        WWWForm form = new WWWForm();
        form.AddField(entryId, data);

        UnityWebRequest www = UnityWebRequest.Post(url, form);

        yield return www.SendWebRequest();
    }

    public IEnumerator Post()
    {
        yield return Post(data);
    }

    public void ApendToData(string data)
    {
        this.data += data;
    }

    public void ClearData()
    {
        data = "";
    }

    //TODO: Expand entryId to a dictionary to map the entryId to an entry-title.
    //TODO: Add a data-variable and methods to access it to add data to specific entries
    //TODO: Generate enums? variables? based on the entry-name, to not have to rely on strings...
}