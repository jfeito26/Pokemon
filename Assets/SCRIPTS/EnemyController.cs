using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Characters enemyCharacter;

    void Start()
    {
        // Puedes asignar el enemigo según lo necesites
        enemyCharacter = new Sukamon("Sukamon");
    }

    public Characters GetCharacter()
    {
        return enemyCharacter;
    }
}
