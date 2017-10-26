using UnityEngine;
using System.Collections;

public class PillerGenerator : MonoBehaviour
{
    public GameObject pillerPrefab;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                GameObject Piller = Instantiate(pillerPrefab) as GameObject;
                Piller.transform.position=new Vector3 (i, 0, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
