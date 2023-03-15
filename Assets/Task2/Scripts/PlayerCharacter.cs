public class PlayerCharacter : Character
{
    public float damageBoost;

    public float GetAttackDamage()
    {
        return weapon.attack * damageBoost;
    }
}