using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public List<QuestDataSO> Quests = new List<QuestDataSO>();

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

    private void Start()
    {
        for (int i = 0; i < Quests.Count; i++)
        {
            Debug.Log($"Quest {i+1} - {Quests[i].QuestName} (최소레벨 {Quests[i].QuestRequriedLevel})");
            Quests[i].ShowContext();
        }
    }
}
