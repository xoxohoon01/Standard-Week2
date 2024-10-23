using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuest", menuName = "QuestData/EncounterQuestData", order = 0)]
public class EncounterQuestDatSO : QuestDataSO
{
    public string encounterTarget;

    public override void ShowContext()
    {
        Debug.Log($"{encounterTarget}�԰� ��ȭ�ϱ�.");
    }
}
