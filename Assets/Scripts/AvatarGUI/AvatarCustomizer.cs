using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarCustomizer : MonoBehaviour
{
    [SerializeField] AvatarOptions headOptions;
    [SerializeField] UnityEngine.UI.Image headImage;
    AvatarData avatarData = new AvatarData();

    private void Start()
    {
        DisplayAvatarData();
    }
    void DisplayAvatarData()
    {
        headImage.sprite = headOptions.optionsList[avatarData.headIndex];
    }
}
