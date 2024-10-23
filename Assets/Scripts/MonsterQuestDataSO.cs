using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestData", menuName = "QuestData/MonsterQuestData", order = 0)]
public class MonsterQuestDataSO : QuestDataSO
{
    [SerializeField] private int monsterAmount;
}
