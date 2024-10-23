using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestData", menuName = "QuestData/MonsterQuestData", order = 0)]
public class MonsterQuestDataSO : QuestDataSO
{
    public string monsterName;
    public int monsterAmount;

    public override void ShowContext()
    {
        Debug.Log($"{monsterName}��(��) {monsterAmount}���� �����ϱ�.");
    }
}
