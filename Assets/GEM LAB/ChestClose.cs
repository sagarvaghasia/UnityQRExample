using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestClose : MonoBehaviour
{
    public TextMesh initialText;
    public TextMesh rightText;
    public TextMesh wrongText;
    public GameObject chestOpen;
    public GameObject chestClose;

    public void onClickButton()
    {
        initialText.gameObject.SetActive(false);
        rightText.gameObject.SetActive(false);
        wrongText.gameObject.SetActive(true);
        chestOpen.SetActive(false);
        chestClose.SetActive(true);
    }
}
