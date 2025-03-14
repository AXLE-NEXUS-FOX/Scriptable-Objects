using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

	public new string name;
	public string description;

	public Sprite artwork;

	public int manaCost;
	public int attack;
	public int health; 
    public enum Element { Fire, Water, Earth, Life, Undead };
    public Element TheElement;
    private int ElementArrayNum;
   [HideInInspector] public Sprite ElementImage;
    

	private void Awake()
	{
        
        

       
    }
    public void Print ()
	{
		Debug.Log(name + ": " + description + " The card costs: " + manaCost);
	}

}
