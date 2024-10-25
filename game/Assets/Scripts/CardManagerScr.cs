using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defence, Heal, Bum;

    public Card(string name, string logoPath, int attack, int defenсe, int heal, int bum)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack; Defence = defenсe; Heal = heal; Bum = bum;
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
        CardManager.AllCards.Add(new Card("бибиз€ны", "memes/бибиз€ны", 0, 10, 0, 0));
        CardManager.AllCards.Add(new Card("к хэллоуину готовы", "memes/бэтмен", 0, 5, 0, 0));
        CardManager.AllCards.Add(new Card("сок €блоко-апельсин", "memes/котыфрукты", 0, 10, 0, 0));
        CardManager.AllCards.Add(new Card("лолька димона", "memes/крутойкот", 0, 12, 0, 0));
        CardManager.AllCards.Add(new Card("покажите пропуск пожалуйста", "memes/мартышки", 0, 20, 0, 0));
        CardManager.AllCards.Add(new Card("держим район", "memes/охрана", 0, 15, 0, 0));
        CardManager.AllCards.Add(new Card("привет мы ковбои а почему ты смеешьс€", "memes/порос€та", 0, 8, 0, 0));
        CardManager.AllCards.Add(new Card("лав", "memes/божьикоровки", 0, 0, 14, 0));
        CardManager.AllCards.Add(new Card("у бабушки на огороде", "memes/кактус", 0, 0, 5, 0));
        CardManager.AllCards.Add(new Card("глаћ”–", "memes/мороженое", 0, 0, 10, 0));
        CardManager.AllCards.Add(new Card("не тормози, съешь сникерсни", "memes/св€тойисточник", 0, 0, 20, 0));
        CardManager.AllCards.Add(new Card("€ и кто", "memes/тюлени", 0, 0, 10, 0));
        CardManager.AllCards.Add(new Card("в столовку на перемене", "memes/кони", 0, 0, 0, 12));
        CardManager.AllCards.Add(new Card("лабораторна€ по химии", "memes/коты", 0, 0, 0, 3));
        CardManager.AllCards.Add(new Card("вот они справа налево", "memes/майлитлпони", 0, 0, 0, 21));
        CardManager.AllCards.Add(new Card("нокаут", "memes/бабул€", 25, 0, 0, 0));
        CardManager.AllCards.Add(new Card("не ори на мен€", "memes/волк", 10, 0, 0, 0));
        CardManager.AllCards.Add(new Card("а почему пробки выбило", "memes/гидра", 12, 0, 0, 0));
        CardManager.AllCards.Add(new Card("кака€ мила€ девушка, интересно что у неЄ в наушниках", "memes/земл€", 7, 0, 0, 0));
        CardManager.AllCards.Add(new Card("это моЄ болото", "memes/котзевс", 10, 0, 0, 0));
        CardManager.AllCards.Add(new Card("похорошела москва", "memes/котигуана", 18, 0, 0, 0));
        CardManager.AllCards.Add(new Card("да, у мен€ 10 по матану", "memes/котпл€жвзрыв", 26, 0, 0, 0));
        CardManager.AllCards.Add(new Card("о нет дедлайны", "memes/криперы", 15, 0, 0, 0));
        CardManager.AllCards.Add(new Card("сейчас €ичницу поджарим", "memes/лазеры3", 11, 0, 0, 0));
        CardManager.AllCards.Add(new Card("никто не выживет", "memes/лазеры4", 7, 0, 0, 0));
        CardManager.AllCards.Add(new Card("мастер спорта по ноге", "memes/миньон", 13, 0, 0, 0));
        CardManager.AllCards.Add(new Card("экскаватор", "memes/ньюйорк", 20, 0, 0, 0));
        CardManager.AllCards.Add(new Card("ой сломалось", "memes/огнедышащий", 11, 0, 0, 0));
        CardManager.AllCards.Add(new Card("красивый закат", "memes/пинкивзрыв", 9, 0, 0, 0));
        CardManager.AllCards.Add(new Card("нарушаете?", "memes/тигркачок", 25, 0, 0, 0));

    }
}

