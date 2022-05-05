using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormData : MonoBehaviour
{
    [SerializeField] protected FormObject form;
    [SerializeField] protected string key;
    [SerializeField] protected string value;

    public void UpdateValue(string value)
    {
        this.value = value;
        form.Set(key, value);
    }

    public void SendForm()
    {
        StartCoroutine(form.Post());
    }
}
