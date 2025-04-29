using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private int rows = 5;
    [SerializeField] private int cols = 5;
    [SerializeField] private float spacing = 2f;
    [SerializeField] private GameObject bushPrefab;
    [SerializeField][Range(0f, 1f)] private float combatChance = 0.3f;

    [Header("Posición inicial")]
    [SerializeField] private Vector2 startPosition = new Vector2(0, 0);

    private List<GameObject> spawnedBushes = new List<GameObject>();

    void Start()
    {
        GenerateBushGrid();
    }

    public void GenerateBushGrid()
    {
        // Limpiamos arbustos existentes
        ClearExistingBushes();

        // Generamos nueva cuadrícula
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector3 position = new Vector3(
                    startPosition.x + col * spacing,
                    startPosition.y + row * spacing,
                    0f);

                GameObject bush = Instantiate(bushPrefab, position, Quaternion.identity, transform);
                spawnedBushes.Add(bush);

                // Aleatoriamente añadimos componente de combate
                if (Random.value < combatChance)
                {
                    bush.AddComponent<BushCombat>(); // Asume que tenemos este componente
                    bush.name = "Bush (Combat)";
                }
                else
                {
                    bush.name = "Bush (Safe)";
                }
            }
        }
    }

    private void ClearExistingBushes()
    {
        foreach (var bush in spawnedBushes)
        {
            if (bush != null)
            {
                Destroy(bush);
            }
        }
        spawnedBushes.Clear();
    }

    
    [ContextMenu("Regenerar Arbustos")]
    private void RegenerateBushes()
    {
        GenerateBushGrid();
    }
}
