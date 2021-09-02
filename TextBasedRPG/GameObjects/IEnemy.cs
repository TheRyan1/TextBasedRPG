namespace TextBasedRPG.GameObjects
{
    public enum EnemyTypes
    {
        Juggernaut,
        Imp,
        Asshole
    }

    public interface IEnemy
    {
        public EnemyTypes Type { get; set; }
    }
}