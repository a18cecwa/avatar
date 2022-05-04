using System.Collections;
using UnityEngine;

public static class Utility
{
    public static void DestroyAllChildren(this Transform parent)
    {
        for (int i = parent.childCount - 1; i >= 0; i--)
        {
            Object.Destroy(parent.GetChild(i));
        }
    }
}