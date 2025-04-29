using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Characters
{
    public Cowboy(string name) : base()
    {
        this.name = "cowboy";
    }

    public Cowboy(string name, float damage) : base(100, "cowboy", Resources.Load<Sprite>("Sprites/nombreSrpite"), 15)
    {

    }

    public override float Attack()
    {
        float randomDamage = Random.Range(1f, 1.5f);
        return GetDamage() * randomDamage;
    }

    public override float Heal()
    {
        return Heal();
    }
}
