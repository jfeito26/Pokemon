using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEncounter : MonoBehaviour
{
    [Header("Configuración de Combate")]
    [SerializeField] private Characters enemy; //desde el inspector
    [SerializeField] private int minEnemies = 1;
    [SerializeField] private int maxEnemies = 3;

    public void StartEncounter(Characters player)
    {
        // Lógica para iniciar el combate
        int enemyCount = Random.Range(minEnemies, maxEnemies + 1);
        Debug.Log($"¡Combate iniciado contra {enemyCount} {enemy.name}!");

        
        //Abrir una escena de combate, iniciar un sistema de turnos, etc.
    }
}
