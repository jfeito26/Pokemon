using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private bool isPlayerTurn = true;
    private Characters playerCharacter;
    private Characters enemyCharacter;

    void Start()
    {
        // Obtener referencias a los personajes
        playerCharacter = GetComponent<InstantiateCharacter>().GetCharacter(); // Asume que tienes un PlayerController
        enemyCharacter = FindObjectOfType<EnemyController>().GetCharacter(); // Asume que tienes un EnemyController

        if (playerCharacter == null || enemyCharacter == null)
        {
            Debug.LogError("Faltan componentes de personaje");
            enabled = false;
            return;
        }

        Debug.Log($"Comienza el combate! {playerCharacter.GetName()} vs {enemyCharacter.GetName()}");
        Debug.Log("Es tu turno. Click izquierdo: Atacar | Click derecho: Curar");
    }

    void Update()
    {
        if (!isPlayerTurn) return;

        if (Input.GetMouseButtonDown(0)) // Atacar
        {
            PlayerAttack();
        }
        else if (Input.GetMouseButtonDown(1)) // Curar
        {
            PlayerHeal();
        }
    }

    private void PlayerAttack()
    {
        float damage = playerCharacter.Attack();
        enemyCharacter.TakeDamage(damage);
        Debug.Log($"{playerCharacter.GetName()} ataca a {enemyCharacter.GetName()} y le hace {damage} de daño!");

        CheckEnemyHealth();
        StartCoroutine(EnemyTurn());
    }

    private void PlayerHeal()
    {
        float healAmount = playerCharacter.Heal();
        Debug.Log($"{playerCharacter.GetName()} se cura {healAmount} puntos de vida!");

        StartCoroutine(EnemyTurn());
    }

    private IEnumerator EnemyTurn()
    {
        isPlayerTurn = false;
        yield return new WaitForSeconds(1.5f); // Pausa para el turno del enemigo

        // Decisión aleatoria del enemigo (50% atacar, 50% curar)
        if (Random.value > 0.5f)
        {
            float damage = enemyCharacter.Attack();
            playerCharacter.TakeDamage(damage);
            Debug.Log($"{enemyCharacter.GetName()} ataca a {playerCharacter.GetName()} y le hace {damage} de daño!");
        }
        else
        {
            float healAmount = enemyCharacter.Heal();
            Debug.Log($"{enemyCharacter.GetName()} se cura {healAmount} puntos de vida!");
        }

        CheckPlayerHealth();
        isPlayerTurn = true;
    }

    private void CheckPlayerHealth()
    {
        if (playerCharacter.GetHealth() <= 0)
        {
            Debug.Log($"¡{playerCharacter.GetName()} ha sido derrotado!");
            EndCombat();
        }
    }

    private void CheckEnemyHealth()
    {
        if (enemyCharacter.GetHealth() <= 0)
        {
            Debug.Log($"¡{enemyCharacter.GetName()} ha sido derrotado!");
            EndCombat();
        }
    }

    private void EndCombat()
    {
        Debug.Log("El combate ha terminado.");
        Destroy(this); // Elimina este componente
    }
}
