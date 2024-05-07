using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject spawnTarget;
    [SerializeField] int Targets = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Targets; i++)
        {
            float x = Random.Range(-4.0f, 4.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Instantiate(spawnTarget, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}
