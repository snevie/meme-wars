using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defence, Heal, Bum;

    public Card(string name, string logoPath, int attack, int defen�e, int heal, int bum)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack; Defence = defen�e; Heal = heal; Bum = bum;
    }
}
public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();
}
public class CardManagerScr : MonoBehaviour
{
    public void Awake()
    {
        CardManager.AllCards.Add(new Card("��������", "memes/��������", 0, 10, 0, 0));
        CardManager.AllCards.Add(new Card("� ��������� ������", "memes/������", 0, 5, 0, 0));
        CardManager.AllCards.Add(new Card("��� ������-��������", "memes/����������", 0, 10, 0, 0));
        CardManager.AllCards.Add(new Card("������ ������", "memes/���������", 0, 12, 0, 0));
        CardManager.AllCards.Add(new Card("�������� ������� ����������", "memes/��������", 0, 20, 0, 0));
        CardManager.AllCards.Add(new Card("������ �����", "memes/������", 0, 15, 0, 0));
        CardManager.AllCards.Add(new Card("������ �� ������ � ������ �� ��������", "memes/��������", 0, 8, 0, 0));
        CardManager.AllCards.Add(new Card("���", "memes/������������", 0, 0, 14, 0));
        CardManager.AllCards.Add(new Card("� ������� �� �������", "memes/������", 0, 0, 5, 0));
        CardManager.AllCards.Add(new Card("������", "memes/���������", 0, 0, 10, 0));
        CardManager.AllCards.Add(new Card("�� �������, ����� ���������", "memes/��������������", 0, 0, 20, 0));
        CardManager.AllCards.Add(new Card("� � ���", "memes/������", 0, 0, 10, 0));
        CardManager.AllCards.Add(new Card("� �������� �� ��������", "memes/����", 0, 0, 0, 12));
        CardManager.AllCards.Add(new Card("������������ �� �����", "memes/����", 0, 0, 0, 3));
        CardManager.AllCards.Add(new Card("��� ��� ������ ������", "memes/�����������", 0, 0, 0, 21));
        CardManager.AllCards.Add(new Card("������", "memes/������", 25, 0, 0, 0));
        CardManager.AllCards.Add(new Card("�� ��� �� ����", "memes/����", 10, 0, 0, 0));
        CardManager.AllCards.Add(new Card("� ������ ������ ������", "memes/�����", 12, 0, 0, 0));
        CardManager.AllCards.Add(new Card("����� ����� �������, ��������� ��� � �� � ���������", "memes/�����", 7, 0, 0, 0));
        CardManager.AllCards.Add(new Card("��� �� ������", "memes/�������", 10, 0, 0, 0));
        CardManager.AllCards.Add(new Card("���������� ������", "memes/���������", 18, 0, 0, 0));
        CardManager.AllCards.Add(new Card("��, � ���� 10 �� ������", "memes/������������", 26, 0, 0, 0));
        CardManager.AllCards.Add(new Card("� ��� ��������", "memes/�������", 15, 0, 0, 0));
        CardManager.AllCards.Add(new Card("������ ������� ��������", "memes/������3", 11, 0, 0, 0));
        CardManager.AllCards.Add(new Card("����� �� �������", "memes/������4", 7, 0, 0, 0));
        CardManager.AllCards.Add(new Card("������ ������ �� ����", "memes/������", 13, 0, 0, 0));
        CardManager.AllCards.Add(new Card("����������", "memes/�������", 20, 0, 0, 0));
        CardManager.AllCards.Add(new Card("�� ���������", "memes/�����������", 11, 0, 0, 0));
        CardManager.AllCards.Add(new Card("�������� �����", "memes/����������", 9, 0, 0, 0));
        CardManager.AllCards.Add(new Card("���������?", "memes/���������", 25, 0, 0, 0));

    }
}

