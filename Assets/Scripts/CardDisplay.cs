using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;

	public Text manaText;
	public Text attackText;
	public Text healthText;
	public Image elementImage;
    private GameObject ElementHolder;

    // Use this for initialization
    void Start () {
		nameText.text = card.name;
		descriptionText.text = card.description;
		artworkImage.sprite = card.artwork;
        elementImage.sprite = card.ElementImage;
        manaText.text = card.manaCost.ToString();
		attackText.text = card.attack.ToString();
		healthText.text = card.health.ToString();
        ElementHolder = GameObject.Find("Main Camera");

        switch (card.TheElement)
        {
            case Card.Element.Fire:
                card.ElementImage = ElementHolder.GetComponent<ElementHolder>().ElementSprites[1];
                Debug.Log(this.name + " is a Fire card");
                break;
            case Card.Element.Water:
                card.ElementImage = ElementHolder.GetComponent<ElementHolder>().ElementSprites[4];
                Debug.Log(this.name + " is a Water card");
                break;
            case Card.Element.Earth:
                card.ElementImage = ElementHolder.GetComponent<ElementHolder>().ElementSprites[0];
                Debug.Log(this.name + " is a Earth card");
                break;
            case Card.Element.Life:
                card.ElementImage = ElementHolder.GetComponent<ElementHolder>().ElementSprites[2];
                Debug.Log(this.name + " is a Life card");
                break;
            case Card.Element.Undead:
                card.ElementImage = ElementHolder.GetComponent<ElementHolder>().ElementSprites[3];
                Debug.Log(this.name + " is a Undead card");
                break;
        }
    }

	 // Call this method to update the card display
    public void UpdateCardDisplay()
    {
        if (card != null)
        {
            nameText.text = card.name;
            descriptionText.text = card.description;
            artworkImage.sprite = card.artwork;
            manaText.text = card.manaCost.ToString();
            attackText.text = card.attack.ToString();
            healthText.text = card.health.ToString();
        }
        else
        {
            Debug.LogWarning("Card is not assigned!");
        }
    }
	
}
