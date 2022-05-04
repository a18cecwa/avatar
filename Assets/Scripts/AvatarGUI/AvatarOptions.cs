using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AvatarOptions", order = 1)]
public class AvatarOptions : ScriptableObject
{
    public List<GameObject> optionsList;
}

public enum AvatarOptionType
{
    EYES,
    MOUTH
}
