using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardObejct : MonoBehaviour
{
    public CardData data;

    Image icon;
    Text cardName;
    Text cardDes;


    void Start()
    {
        CardSet();
    }

    public void CardSet()
    {
        int ran = Random.Range(0, GameManager.instance.cardData.Length);

        // 초기화
        data = GameManager.instance.cardData[ran];
        icon = GetComponentsInChildren<Image>()[1];
        cardName = GetComponentsInChildren<Text>()[0];
        cardDes = GetComponentsInChildren<Text>()[1];

        // 세팅
        icon.sprite = data.cardSprite;
        cardName.text = data.cardName;
        cardDes.text = data.cardDes;
    }

    public void UseCard()
    {
        Debug.Log(data.name);
        Debug.Log(data.cardDes);
    }
}
