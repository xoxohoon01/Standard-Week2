using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDataSO : ScriptableObject
{
    public string QuestName;
    public int QuestRequriedLevel;
    public int QuestNPC;
    public int QuestRequisites;

    public virtual void ShowContext()
    {
    }
}
