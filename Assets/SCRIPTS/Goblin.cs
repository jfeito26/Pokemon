using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Characters
{
    public Goblin(string name) : base()
    {
        this.name = "Goblin";
    }

    public Goblin(string name, float damage) : base(100, "Goblin", Resources.Load<Sprite>("Sprites/nombreSrpite"), 10)
    {

    }

    public override float Attack()
    {
        if(GetHealth() < 20)
        {
            return GetDamage() * 3;
        }
        return GetDamage();
    }

    public override float Heal()
    {

        return GetDamage() / 2;
    }
}
