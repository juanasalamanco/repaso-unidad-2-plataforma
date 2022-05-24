using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggMaker : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject eggspawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(eggPrefab);
            clon.transform.position = eggspawnpoint.transform.position;
        }
    }
}
