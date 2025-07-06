using UnityEngine;

namespace SewerSocket.Messages
{
    public abstract class SewerSocket_MSG
    {
        public enum MessageType
        {
            GameReset,
            FruitUpdate
        };

        [SerializeField] protected MessageType Type;
    }
}
