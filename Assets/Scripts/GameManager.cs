using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CardData[] cardData; // 카드 데이터
    public Button[] cards; // 카드들

    void Awake()
    {
        instance = this;
    }


    public void ResetCard()
    {
        for (int index = 0; index < cards.Length; index++)
        { 
            // 카드 데이터 다시 설정
            CardObejct cardLogic = cards[index].GetComponent<CardObejct>();
            cardLogic.CardSet();
        }
    }
}
