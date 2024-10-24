using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string name;
        public GameObject prefab;
        public int poolSize;
    }

    public List<Pool> poolList;
    Dictionary<string, List<GameObject>> poolsDict = new Dictionary<string, List<GameObject>>();

    private void Awake()
    {
    }

    void Start()
    {
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
        foreach (var pool in poolList)
        {
            List<GameObject> newList = new List<GameObject>();
            for (int i = 0; i < pool.poolSize; i++)
            {
                GameObject newObject = Instantiate(pool.prefab);
                newObject.SetActive(false);
                newList.Add(newObject);
            }
            poolsDict.Add(pool.name, newList);
        }
    }


    public GameObject Get()
    {
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
        return null;
    }

    public void Release(GameObject obj)
    {
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
        obj.SetActive(false);
    }
}