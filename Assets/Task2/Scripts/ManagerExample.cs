using UnityEngine;

public class ManagerExample : MonoBehaviour
{
    public PlayerCharacter playerCharacter;
    public EnemyNPC enemyNPC;

    private void Start()
    {
        playerCharacter.weapon = new Weapon { weaponName = "Sword", attack = 35, agility = 15 };
        enemyNPC.weapon = new Weapon { weaponName = "Bow and Arrow", attack = 13, agility = 25 };

        Example();
    }

    private void Example()
    {
        Debug.Log("Combat Started: " + playerCharacter.characterName + " vs " + enemyNPC.characterName);
        Debug.Log("Player Character Health: " + playerCharacter.health);
        Debug.Log("Enemy NPC Health: " + enemyNPC.health);

        while (playerCharacter.health > 0 && enemyNPC.health > 0)
        {
            float playerAttackDamage = playerCharacter.GetAttackDamage();
            enemyNPC.TakeDamage(playerAttackDamage);
            Debug.Log(playerCharacter.characterName + " attacked " + enemyNPC.characterName + " for " + playerAttackDamage + " damage.");
            Debug.Log(enemyNPC.characterName + " Health: " + enemyNPC.health);

            //=-----------------------//
            float enemyAttackDamage = enemyNPC.weapon.attack;
            playerCharacter.TakeDamage(enemyAttackDamage);
            Debug.Log(enemyNPC.characterName + " attacked " + playerCharacter.characterName + " for " + enemyAttackDamage + " damage.");
            Debug.Log(playerCharacter.characterName + " Health: " + playerCharacter.health);
        }

        if (playerCharacter.health <= 0)
        {
            Debug.Log(playerCharacter.characterName + " has been defeated.");
        }
        else
        {
            Debug.Log(enemyNPC.characterName + " has been defeated.");
        }
    }
}