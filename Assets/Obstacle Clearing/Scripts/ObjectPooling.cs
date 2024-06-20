using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    // Start is called before the first frame update
    public static ObjectPooling I;
    public List<GameObject> pooledObjects;
    public List<GameObject> ticketPoolObjects;//List of GameObject you want Pool; 
    public GameObject[] objectToPool=new GameObject[2];
    public int amountToPool; //Amount You Want to Pool
    public GameObject player;
    void Awake()
    {
        I = this;
    }
    void Start()
    { 
        InstObject(objectToPool, pooledObjects);
    }
    public void InstObject(GameObject[] objectTo, List<GameObject> poolList)
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject tmp = Instantiate(objectTo[Random.Range(0,2)]);
            tmp.SetActive(false);
            poolList.Add(tmp);
        }
    }
    public GameObject GetPooledObject(List<GameObject> poolList)
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if ( poolList[i].transform.position.z < player.transform.position.z - 10)
            {
                poolList[i].SetActive(false);
                foreach(GameObject game in objectToPool)
                {
                    if (poolList[i].gameObject.tag == game.tag)
                    {
                        poolList[i].gameObject.transform.position = game.transform.position;
                    }
                }
            }
            if (!poolList[i].activeInHierarchy)
            {
                return poolList[i];
            }
        }
        return null;
    }


}
