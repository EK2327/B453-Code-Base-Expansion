using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    enum ButtonTypes
    {
        PlayerButton,
        EnemyButton
    }
    [SerializeField] ButtonTypes type;
    [SerializeField] GameObject[] doors;
    // Start is called before the first frame update
    void Start()
    {
        doors = GameObject.FindGameObjectsWithTag("Player Door");
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
                    door.SetActive(false);
                }
            }
        }
    }
}
