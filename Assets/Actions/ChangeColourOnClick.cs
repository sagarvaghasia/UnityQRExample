using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourOnClick : MonoBehaviour
{
    public Material mat;

    UnityEngine.TouchScreenKeyboard keyboard;
    public static string keyboardText = "";

    public void changeToRed()
    {

        keyboard = TouchScreenKeyboard.Open("text to edit");
    }
}
