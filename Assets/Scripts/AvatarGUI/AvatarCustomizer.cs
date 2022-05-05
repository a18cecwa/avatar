using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarCustomizer : MonoBehaviour
{
    [SerializeField] AvatarOptions options;
    [SerializeField] Transform position;
    [SerializeField] int index;
    [SerializeField] FormData data;

    private void Start()
    {
        DisplayAvatar();
    }

    void DisplayAvatar()
    {
        position.DestroyAllChildren();
        Instantiate(options.optionsList[index], position);
    }

    public void NextOption()
    {
        index = (index + 1) % options.optionsList.Count;
        data.UpdateValue(index.ToString());
        DisplayAvatar();
    }

    public void PreviousOption()
    {
        index = (index + options.optionsList.Count - 1) % options.optionsList.Count;
        data.UpdateValue(index.ToString());
        DisplayAvatar();
    }
}
