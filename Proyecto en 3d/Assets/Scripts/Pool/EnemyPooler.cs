using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public static EnemyPooler Instance;

    private void Awake()
    {
        Instance = this; 
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> pooldictionary;

    // Start is called before the first frame update
    void Start()
    {
        pooldictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objtpool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objtpool.Enqueue(obj);
            }
            pooldictionary.Add(pool.tag, objtpool);
        }
    }

    public GameObject Spawn(string tag, Vector3 position, Quaternion rotation)
    {
        GameObject objspawn = pooldictionary[tag].Dequeue();
        objspawn.SetActive(true);
        objspawn.transform.position = position;
        objspawn.transform.rotation = rotation;
        //pooldictionary[tag].Enqueue(objspawn);

        IPooledEnemy pooledene = objspawn.GetComponent<IPooledEnemy>();

        if(pooledene != null)
        {
            pooledene.EnemyStart();
        }

        return objspawn;
    }
}
