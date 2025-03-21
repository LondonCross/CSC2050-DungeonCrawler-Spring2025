using System;
using UnityEngine;

public abstract class Inhabitant 
{
    protected int currhp;
    protected int maxHp;
    protected int ac;
    
    protected string name;

    public Inhabitant(string name)
    {
        this.name = name;
        this.maxHp = UnityEngine.Random.Range(30, 50);
        this.currhp = this.maxHp;
        this.ac = UnityEngine.Random.Range(10, 20);
    }

    public int getCurrHp()
    {
        return this.currhp;
    }
    public string getName()
    {
        return this.name;
    }
    public int TakeDamage(int dmg)
    {
       currhp -= dmg;
       if (currhp < 0) currhp = 0;
       return currhp;
    }
}
