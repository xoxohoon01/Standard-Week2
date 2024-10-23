using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDataSO : ScriptableObject
{
    [SerializeField] private string QuestName;
    [SerializeField] private int QuestRequriedLevel;
    [SerializeField] private int QuestNPC;
    [SerializeField] private int QuestRequisites;
}
