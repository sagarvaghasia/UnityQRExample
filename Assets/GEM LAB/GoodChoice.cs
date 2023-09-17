using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Used for Text Mesh Pro

public class GoodChoice : MonoBehaviour
{
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;

    public void OnbuttonClickEvent()
    {
        text1.gameObject.SetActive(false); //Disable and Enable text as per user interaction
        text2.gameObject.SetActive(false); //Disable and Enable text as per user interaction
        text3.gameObject.SetActive(true);  //Disable and Enable text as per user interaction
    }
}
