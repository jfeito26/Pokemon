using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType { WIZARD, COWBOY, GOBLIN, SUKAMON };
public abstract class Characters 
{
    public string name;
    private float health, damage;
    private Sprite sprite;
    public Characters()
    {
        health = 100;
        damage = 10;
        name = "Default_Name";
    }

    public Characters(float health, string name, Sprite sprite, float damage)//metodo para inicializar las variables que tenemos\se invoca con (new character(switch))
    {
        this.health = health;
        this.name = name;
        this.sprite = sprite;
        this.damage = damage;
    }

    public float GetHealth()
    {
        return health;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public string GetName()
    {
        return name;
    }

    public float GetDamage()
    {
        return damage;
    }

    public abstract float Attack();

    public virtual float Heal()
    {
       health += 10f;
       health = Mathf.Min(health, 100);
       return health;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0) health = 0;
    }

}
