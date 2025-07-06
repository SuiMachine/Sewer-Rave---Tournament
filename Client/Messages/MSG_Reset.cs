using System;

namespace SewerSocket.Messages
{
    [Serializable]
    public class MSG_Reset : SewerSocket_MSG
    {
        public MSG_Reset()
        {
            Type = MessageType.GameReset;
        } 
    }
}
