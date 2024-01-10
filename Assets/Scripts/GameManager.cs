using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CardData[] cardData; // ī�� ������
    public Button[] cards; // ī���

    void Awake()
    {
        instance = this;
    }


    public void ResetCard()
    {
        for (int index = 0; index < cards.Length; index++)
        { 
            // ī�� ������ �ٽ� ����
            CardObejct cardLogic = cards[index].GetComponent<CardObejct>();
            cardLogic.CardSet();
        }
    }
}
