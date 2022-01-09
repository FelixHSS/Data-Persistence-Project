using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerRecord : IEquatable<PlayerRecord>, IComparable<PlayerRecord>
{
    public string name;
    public int score;
    public PlayerRecord(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        PlayerRecord objAsPlayerRocord = obj as PlayerRecord;
        if (objAsPlayerRocord == null) return false;
        else return Equals(objAsPlayerRocord);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public int CompareTo(PlayerRecord other)
    {
        return this.name.CompareTo(other.name);
    }

    public bool Equals(PlayerRecord other)
    {
        if (this.name == other.name)
        {
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return name + ": " + score;
    }
}
