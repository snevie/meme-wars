using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defense, Heal, Bum;

    public Card(string name, string logoPath, int attack, int defense, int heal, int bum)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack; Defense = defense; Heal = heal; Bum = bum;
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
        CardManager.AllCards.Add(new Card("Бабуля", "memes/бабуля", 5, 0, 0, 0));
        CardManager.AllCards.Add(new Card("гидра", "memes/гидра", 5, 0, 0, 0));
    }
}

