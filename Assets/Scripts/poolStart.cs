using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolStart : MonoBehaviour
{
    [Header("Obj 1")]
    [SerializeField] GameObject prefab;
    [SerializeField] Transform poolParent;

    [SerializeField] List<GameObject> poolObjects;

    public static poolStart Instance;

    private void Start()
    {
        Instance = this;

        for (int i = 0; i < 200; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.parent = poolParent;
            obj.transform.localPosition = Vector3.zero;

            poolObjects.Add(obj);
            
        }
    }

    [SerializeField] int poolValue = 0;
    public GameObject InstantiateObjPool()
    {
        
        if (poolValue < poolObjects.Count)
        {
            poolValue++;
            return poolObjects[poolValue-1];
        }
        else
        {
            poolValue = 0;
            return poolObjects[1];
        }

        
    }

    public void DestroyToPool(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.parent = poolParent;
        obj.transform.localPosition = Vector3.zero;
    }


    private void Update()
    {
        Debug.Log(InstantiateObjPool().name);
    }


}
