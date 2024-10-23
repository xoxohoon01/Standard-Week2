using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuest", menuName = "QuestData/EncounterQuestData", order = 0)]
public class EncounterQuestDatSO : QuestDataSO
{
    [SerializeField] private int encounterAmount;
}
