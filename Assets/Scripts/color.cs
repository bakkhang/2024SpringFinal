using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public GameObject sphere;

    private Material objectsphere;

    void Start()
    {
        objectsphere = sphere.GetComponent<Renderer>().material;

        
    }

    // Update is called once per frame
    void Update()
    {
       switch (dropdown.value)
        {
            case 1: objectsphere.color = Color.gray;
                break;
            case 2: objectsphere.color = Color.black;
                break;
            case 3:
                objectsphere.color = Color.green;
                break;
        }
    }
}

