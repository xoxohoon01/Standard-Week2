using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;
    public static QuestManager Instance
    {
        get 
        {
            if (instance == null)
            {
                QuestManager newQuestManager = FindObjectOfType<QuestManager>();

                if (newQuestManager != null)
                {
                    instance = newQuestManager;
                }
                else
                {
                    GameObject newGameObject = new GameObject();
                    instance = newGameObject.AddComponent<QuestManager>();
                }
            }
            return instance; 
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
