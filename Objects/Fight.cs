using UnityEngine;

public class Fight
{
    private Inhabitant attacker;
    private Inhabitant defender;
    
    Inhabitant monster = new Monster("Monster");
    public Fight()
    {
        int roll = Random.Range(0, 20) + 1;
        if (roll <= 10)
        {
            Debug.Log("Monster first");
            attacker = monster;
            defender = CoreSingleton.thePlayer;
        }
        else
        {
            Debug.Log("Player go first");
            attacker = CoreSingleton.thePlayer;
            defender = monster;
        }
        
    }

    public void startFight()
    {
        //attacker and defender alternate between attacking and defending till one dies
        while(attacker.getCurrHp() > 0 && defender.getCurrHp() > 0)
        {
            Debug.Log(attacker.getName() + "strikes!" );
            int dmg = Random.Range(0, 15) + 1;
            defender.TakeDamage(dmg);
            Debug.Log("The strike does " + dmg + " damage!");
            Debug.Log(defender.getName() + " has " + defender.getCurrHp() + " hp left!");
            Inhabitant switcher = attacker;
            attacker = defender; //defender becomes attacker
            defender = switcher; //defender becomes attacker through switcher
        }
    }
    
}