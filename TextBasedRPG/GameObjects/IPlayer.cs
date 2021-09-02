namespace TextBasedRPG.GameObjects
{
    public interface IPlayer: IGameEntity
    {
        public int Level { get; set; }
    }
}