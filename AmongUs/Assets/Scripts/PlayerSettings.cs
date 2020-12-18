using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EControlType
{
    Mouse,
    KeyBoardMouse
}
public class PlayerSettings : MonoBehaviour
{
    public static EControlType controlType;
    public static string nickname;
}
