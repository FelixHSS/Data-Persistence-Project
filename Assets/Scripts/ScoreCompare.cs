using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreCompare : IComparer<PlayerRecord>
{
    public int Compare(PlayerRecord x, PlayerRecord y)
    {
        return -x.score.CompareTo(y.score);
    }
}
