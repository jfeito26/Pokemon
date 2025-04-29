using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Characters
{
    public Sukamon(string name) : base()
    {
        this.name = "sukamon";
    }

    public Sukamon(string name, float damage) : base(100, "sukamon", Resources.Load<Sprite>("Sprites/nombreSrpite"), 1)
    {

    }

    public override float Attack()
    {
        if (GetHealth() < 5)
        {
            return GetDamage() + 99;
        }
        return GetDamage();
    }

    public override float Heal()
    {

        return GetDamage() / 3;
    }
}
