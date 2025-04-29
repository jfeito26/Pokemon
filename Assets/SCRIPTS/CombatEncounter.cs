using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEncounter : MonoBehaviour
{
    [Header("Enemigo")]
    public Sprite enemySprite;
    public float enemyHealth = 50f;
    public float enemyDamage = 10f;

    void Start()
    {
        // Ejemplo: Crea un enemigo al iniciar (esto es solo para demostración)
        Characters enemy = new Enemy(enemyHealth, "Goblin", enemySprite, enemyDamage);
        Debug.Log($"Enemigo {enemy.GetName()} listo para combatir!");
    }
}

public class Enemy : Characters
{
    public Enemy(float health, string name, Sprite sprite, float damage)
        : base(health, name, sprite, damage) { }

    public override float Attack() => GetDamage(); // Ataque básico
}
