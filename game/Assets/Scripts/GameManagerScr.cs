using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Game
{
    public List<Card> EnemyDeck, PlayerDeck,
                       EnemyHand, PlayerHand,
                        EnemyField, PlayerField;
   
    public Game()
    {
        EnemyDeck = GiveDeckCard();
        PlayerDeck = GiveDeckCard();

        EnemyHand = new List<Card>();
        PlayerHand = new List<Card>();

        EnemyField = new List<Card>();
        PlayerField = new List<Card>();

    }

    List<Card> GiveDeckCard()
    {
        List<Card> list = new List<Card>();
        for (int i = 0; i < 31; i++)
            list.Add(CardManager.AllCards[Random.Range(0, CardManager.AllCards.Count)]);
            return list;
    }   
}
public class GameManagerScr : MonoBehaviour
{
    public Game CurrentGame;
    public Transform EnemyHand, PlayerHand;
    public GameObject CardPref;
    public Button EndTurnBtn;
    int Turn, HP1=100, HP2=100;

    public TextMeshProUGUI HP1t, HP2t;

    public List<CardInfoScr> PlayerHandCards = new List<CardInfoScr>(),
        PlayerFieldCards = new List<CardInfoScr>(),
        EnemyHandCards = new List<CardInfoScr>(),
        EnemyFieldCards = new List<CardInfoScr>();

    //public bool IsPlayerTurn
    //{
    //    get
    //    {
    //        return Turn % 2==0;
    //    }
    //}
    void Start()
    {
        //Turn = 0;

        CurrentGame = new Game();

       
        GiveHandCards(CurrentGame.EnemyDeck, EnemyHand);
        GiveHandCards(CurrentGame.PlayerDeck, PlayerHand);
        //ShowHP();

        //StartCoroutine(TurnFunc());
    }

    void GiveHandCards(List<Card> deck, Transform hand)
    {
        int i = 0;
        while (i++ < 6)
            GiveCardToHand(deck, hand);
    }
    void GiveCardToHand(List<Card> deck, Transform hand)
    {
        if (deck.Count == 0) return;
        Card card = deck[0];
        GameObject cardGO = Instantiate(CardPref, hand, false);

        //if (hand == EnemyHand) EnemyHandCards.Add(cardGO.GetComponent<CardInfoScr>());
        //else PlayerHandCards.Add(cardGO.GetComponent<CardInfoScr>());

        if (hand==EnemyHand)
            cardGO.GetComponent<CardInfoScr>().ShowCardInfo(card);
        else  cardGO.GetComponent<CardInfoScr>().ShowCardInfo(card);
        deck.RemoveAt(0);  
    }

    //void ShowHP()
    //{
    //    HP1t.text = HP1.ToString();
    //    HP2t.text = HP2.ToString();
    //}
    //IEnumerator TurnFunc()
    //{
    //    if (IsPlayerTurn)
    //    {
    //        HP1++;
    //    }
    //    else
    //    {
    //        HP2++;
    //    }
    //    ChangeTurn();
    //}
    //public void ChangeTurn()
    //{
    //    StopAllCoroutines();
    //    Turn++;
    //    EndTurnBtn.interactable = IsPlayerTurn;
    //    if (IsPlayerTurn)
    //        GiveNewCards();
    //    StartCoroutine(TurnFunc());

    //}
    //void GiveNewCards()
    //{
    //    GiveCardToHand(CurrentGame.PlayerDeck, PlayerHand);
    //    GiveCardToHand(CurrentGame.EnemyDeck, EnemyHand);
    //}
}
