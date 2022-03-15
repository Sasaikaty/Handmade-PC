using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Inventory;
    public bool inventory = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InventoryActivate();  
    }
    void InventoryActivate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventory == false)
            {
                inventory = true;
                Inventory.GetComponent<Animator>().SetBool("Isopen", true);
            }
            else
            {
                inventory = false;
                Inventory.GetComponent<Animator>().SetBool("Isopen", false);
            }
        }
    }
}
