using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Contactable
{
    protected override void Contant(GameObject _gObject)
    {
        Player.TakeDamage(value);
        if(AfterDestory)
            Destroy(gameObject);
    }
}
