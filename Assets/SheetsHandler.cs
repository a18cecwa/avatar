using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SheetsHandler : MonoBehaviour
{
    [SerializeField]
    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSf9hBmUneXFWdSIKP2caL2R0G_mtDElpv9pgapO747MbYdZvw/formResponse";
    IEnumerator Post(string data)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1432675603", data);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }

    public void SendText(string text)
    {
        StartCoroutine(Post(text));
    }
}
