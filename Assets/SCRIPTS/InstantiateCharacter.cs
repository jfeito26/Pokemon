using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class InstantiateCharacter : MonoBehaviour
{
    public GameObject playerPrefab;
    public CharacterType characterType;

    private Characters character;

    internal Characters GetCharacter()
    {
        return character;
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (characterType)
        {
            case CharacterType.WIZARD:
                character = new Wizard("Wizard", 45);
                break;
            case CharacterType.COWBOY:
                character = new Cowboy("Cowboy", 100);
                break;
        }
        GameObject pl0 = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        pl0.GetComponent<SpriteRenderer>().sprite = character.GetSprite();


    }
}

