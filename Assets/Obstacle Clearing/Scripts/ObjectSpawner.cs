using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> pipe = new List<GameObject>();
    [SerializeField] Vector3 spawnPoint;
    [SerializeField] float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObj), 1.5f, Random.Range(2,3));
       // InvokeRepeating(nameof(TicketSpawn), 4f, 1.5f);
    }
    public void SpawnObj()
    {
        if (Helper.GameOver==false && Helper.StartGame==true)
        {
            GameObject obj = ObjectPooling.I.GetPooledObject(ObjectPooling.I.pooledObjects);
            obj.transform.position = new Vector3(obj.transform.position.x,obj.transform.position.y,25);
            obj.SetActive(true);
        }
    }

}
