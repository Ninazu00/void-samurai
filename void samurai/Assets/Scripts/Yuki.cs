using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuki : EnemyController
{
    public Transform target;

    protected override void  EnemyBehavior()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.transform.position,moveSpeed*Time.deltaTime);
        return;
    }
}