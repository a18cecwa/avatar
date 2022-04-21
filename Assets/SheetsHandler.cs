using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SheetsHandler : MonoBehaviour
{
    [SerializeField] FormObject formObject;
    IEnumerator Post(string data)
    {
        WWWForm form = new WWWForm();
        form.AddField(formObject.entryId, data);

        UnityWebRequest www = UnityWebRequest.Post(formObject.url, form);

        yield return www.SendWebRequest();
    }

    public void SendText(string text)
    {
        StartCoroutine(Post(text));
    }
}
