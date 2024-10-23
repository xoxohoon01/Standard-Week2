using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    private Dictionary<string, List<GameObject>> pools = new Dictionary<string, List<GameObject>>();
    public int poolSize = 300;

    private void Awake()
    {
        pools.Add("Monster", pool);
    }

    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for (int i = 0; i < poolSize; i++)
        {
            GameObject newGameObject = Instantiate(prefab);
            newGameObject.SetActive(false);
        }
    }

    public GameObject Get()
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        for (int i = 0; i < poolSize; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                return pool[i];
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);
    }
}