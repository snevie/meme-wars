using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Card;

public class CardInfoScr : MonoBehaviour
{
    public Card SelfCard;
    public Image Logo;
    public TextMeshProUGUI Name;

    public void ShowCardInfo(Card card)
    {
        Logo.sprite = card.Logo;
        Logo.preserveAspect = true;
        Name.text = card.Name;  

        //Attack.text=SelfCard.Attack.ToString();
        //Defence.text = SelfCard.Defence.ToString();
        //Heal.text = SelfCard.Heal.ToString();
        //Bum.text = SelfCard.Bum.ToString();
    }

    private void Start()
    {
        //ShowCardInfo(CardManager.AllCards[transform.GetSiblingIndex()]);
    }
}
