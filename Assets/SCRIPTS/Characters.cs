using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType { WIZARD, COWBOY, GOBLIN, SUKAMON };
public class Characters 
{
    public string name;
    private float health, damage;
    private Sprite sprite;
    public Characters()
    {
        health = 100;
        damage = 10;
    }
   
}
