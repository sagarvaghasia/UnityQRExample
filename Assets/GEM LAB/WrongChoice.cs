using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongChoice : MonoBehaviour
{
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;

    public void buttonClickEvent()
    {
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);
        text3.gameObject.SetActive(false);
    }
}
