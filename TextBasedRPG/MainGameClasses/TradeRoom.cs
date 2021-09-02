using System.Linq;
using TextBasedRPG.GameObjects;

namespace TextBasedRPG.MainGameClasses
{
    public class TradeRoom<T, TC>
        where T : IPlayer
        where TC: IGameEntity
    {
        private readonly T _player;
        private readonly TC _npc;

        public TradeRoom(T player, TC npc)
        {
            _player = player;
            _npc = npc;
        }

        public bool MakeTrade(int index)
        {
            _player.Inventory.Add(_npc.Inventory[index]);
            _npc.Inventory.RemoveAt(index);
            return true;
        }
    }
    
    public static class TradeExtensions 
    {
        public static bool MakeTrade<T, TC>(this T player, TC npc, int index) 
            where T : IPlayer
            where TC: IGameEntity
        {
            player.Inventory.Add(npc.Inventory[index]);
            npc.Inventory.RemoveAt(index);
            return true;
        }
    }
}