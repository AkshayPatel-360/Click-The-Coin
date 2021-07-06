using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPuller : MonoBehaviour
{
    public static ObjectPuller currentObjectPuller;
    public GameObject PulledObject;
    [SerializeField] private int pullAmount;
    private bool willGrow;

    private List<GameObject> pulledObjects;



    // Start is called before the first frame update
    void Start()
    {
        currentObjectPuller = this;
        pulledObjects = new List<GameObject>();

        for (int i = 0; i < pullAmount; i++)
        {
            GameObject obj = Instantiate(PulledObject);
            obj.SetActive(false);
            pulledObjects.Add(obj);
        }
    }

    public GameObject DepullObject()
    {
        for (int i = 0; i < pulledObjects.Count; i++)
        {
            if (!pulledObjects[i].activeInHierarchy)
            {
                return pulledObjects[i];

            }
        }

        if (willGrow)
        {
            GameObject obj = Instantiate(PulledObject);
            pulledObjects.Add(obj);
            return obj;
        }

        return null;
    }
   

}
