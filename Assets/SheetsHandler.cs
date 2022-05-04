using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SheetsHandler : MonoBehaviour
{
    [SerializeField] FormObject formObject;

    public void SendText(string text)
    {
        StartCoroutine(formObject.Post(text));
    }
}
