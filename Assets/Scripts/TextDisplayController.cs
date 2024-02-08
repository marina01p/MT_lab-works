using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextDisplayController : MonoBehaviour
{
    public TextMeshProUGUI myText;

    private int currentIndex = 1;
    private string[] textLines = {"Hello!", "My Name is John.", "Where should I go?"};

    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonNext;

    public Image imageObject;
    public Sprite[] sprites;

    void Start()
    {
        buttonOne.SetActive(false);
        buttonTwo.SetActive(false);

        if (textLines.Length > 0)
        {
            myText.text = textLines[0];
        }
    }

    public void DisplayNextText()
    {
        if (currentIndex < textLines.Length)
        {
            myText.text = textLines[currentIndex];

            ChangeSpriteBasedOnText(currentIndex);

            currentIndex++;
        }
        if (currentIndex == textLines.Length)
        {
            buttonOne.SetActive(true);
            buttonTwo.SetActive(true);

            buttonNext.SetActive(false);
        }
    }

    private void ChangeSpriteBasedOnText(int index)
    {
        if (index >= 0 && index < sprites.Length)
        {
            imageObject.sprite = sprites[index];
        }
    }
}
