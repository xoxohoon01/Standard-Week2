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
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
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
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        return null;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);
    }
}