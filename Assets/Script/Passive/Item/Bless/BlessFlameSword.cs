﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlessFlameSword : Item
{
    public override void GetItem()
    {
        if (TryGetComponent<Attack>(out var a))
            a.color = Colors.Sage;
    }
    public override void DiscardItem()
    {
        if (TryGetComponent<Attack>(out var a))
            a.color = Color.white;
    }
    public override void OnSucceedDamage(Damage damage, Role target)
    {
        Buff.GiveBuff(BuffType.Flame, 1,3f, role, target);
    }
}