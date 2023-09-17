using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public TextMesh initialText;
    public TextMesh rightText;
    public TextMesh wrongText;
    public GameObject chestOpen;
    public GameObject chestClose;

    public void onClickButton()
    {
        initialText.gameObject.SetActive(false);
        rightText.gameObject.SetActive(true);
        wrongText.gameObject.SetActive(false);
        chestOpen.SetActive(true);
        chestClose.SetActive(false);
    }
}
