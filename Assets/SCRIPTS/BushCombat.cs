using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushCombat : MonoBehaviour
{
    [SerializeField] private CombatEncounter encounterPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCombat();
        }
    }

    private void StartCombat()
    {
        Debug.Log("¡Combate iniciado!");
        // Instantiate(encounterPrefab, Vector3.zero, Quaternion.identity);
      
    }
}
