using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    /*
     * -*- Door Buttons must be on the Ignore Raycast Layer so that Kiwis can walk over them -*-
     */
    enum ButtonTypes
    {
        PlayerButton,
        EnemyButton
    }
    [SerializeField] ButtonTypes type;
    [SerializeField] Sprite pressedSprite;
    [SerializeField] GameObject[] doors;
    // Start is called before the first frame update
    void Start()
    {
        if (type == ButtonTypes.PlayerButton)
        {
            doors = GameObject.FindGameObjectsWithTag("Player Door");
        }
        else if (type == ButtonTypes.EnemyButton)
        {
            doors = GameObject.FindGameObjectsWithTag("Enemy Door");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (type == ButtonTypes.PlayerButton)
        {
            if (collision.gameObject.tag == "Player")
            {
                foreach(GameObject door in doors)
                {
                    door.GetComponent<Door>().Open();
                }
                GetComponent<SpriteRenderer>().sprite = pressedSprite;
            }
        }
        else if(type == ButtonTypes.EnemyButton)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                foreach (GameObject door in doors)
                {
                    door.GetComponent<Door>().Open();
                }
                GetComponent<SpriteRenderer>().sprite = pressedSprite;
            }
        }
    }
}
