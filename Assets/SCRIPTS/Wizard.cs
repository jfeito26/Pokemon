using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Wizard : Characters
{
    private float damageMultiplier = 20;
    public Wizard(string name) : base()
    {
        this.name = "Wizard";
    }

    public Wizard(string name, float damageMultiplayer) : base(100, "Wizard", Resources.Load<Sprite>("Sprites/nombreSrpite"), 20)
    {
        this.damageMultiplier = damageMultiplayer; ;
    }

    public override float Attack()
    {
        
        return GetDamage() * GetDamage() * damageMultiplier;
    }

    //public override float Heal()
    //{
    //    float healAmount = Random.Range(GetDamage(), GetDamage() * damageMultiplier); 
    //     += healAmount;
    //    return Heal();
    //}
}
