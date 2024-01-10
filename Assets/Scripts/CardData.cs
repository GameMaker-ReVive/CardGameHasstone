using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Scriptble Object/CardData")] // CreateAssetMenu : Ŀ���� �޴��� �����ϴ� �Ӽ�
public class CardData : ScriptableObject
{
    // ī�� Ÿ��
    // �нú� : ���ݷ� ���� + 10%, ���ݷ� ���� + 20%, ���ݼӵ� ���� + 10%, ���ݼӵ� ���� ���� + 20%, ĳ���� �̵��ӵ� ����  + 20, ���� ����, ũ��Ƽ�� Ȯ��
    // ��Ƽ�� : ���� ����, ���ΰ�����(�ǰ� 1��), ���� ����, ���ֵ� �ִ� ü�� ����, ü�� ȸ��
    public enum CardType { AttackDamage, AttackSpeed, UnitSpeed, Defense, Critical, rangeAttack, BossAttack, MagicalAttack, UnitMaxHealth, Heal } // enum ������ �����ʹ� ���� ���·ε� ��� ����

    [Header("# Main Info")]
    public CardType cardType; // ī�� Ÿ��
    public int cardId; // ī�� id
    public string cardName; // ī�� �̸�
    [TextArea] // �ν����Ϳ� �ؽ�Ʈ�� ���� �� ���� �� �ְ� ���ִ� �Ӽ�
    public string cardDes; // ī�� ����
    public Sprite cardSprite; // ī�� ������


    [Header("# Passive Card Data")]
    public float upValue; // ���� ��ġ

    [Header("# Active Card Data")]
    public float damagePercent; // ������ ��ġ
    public float healPercent; // ü�� ��ġ
}
