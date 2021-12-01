using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_B_HumanSarface : HumanSarface
{
    Transform[] target;
    int currentTargetNumber;
    float npcSpeed = 5f;
    Vector3 direction;
    Quaternion rotGoal;
    float rotationSpeed;


    void Update()
    {
        //NPC__CharacterMovementTowardsMultiPositions(this.gameObject, currentTargetNumber, npcSpeed,direction, rotGoal, rotationSpeed);
    }
}
