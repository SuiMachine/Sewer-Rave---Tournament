using UnityEngine;

namespace SewerSocket.Messages
{
    public class MSG_FoodState : SewerSocket_MSG
    {
        [SerializeField] private int m_FruitAmount;
        public int FruitAmount
        {
            get => m_FruitAmount;
            set
            {
                if (m_FruitAmount != value)
                {
                    m_FruitAmount = value;
                    IsDirty = true;
                }
            }
        }

        [SerializeField] private int m_CheeseAmount;
        public int CheeseAmount
        {
            get => m_CheeseAmount;
            set
            {
                if (m_CheeseAmount != value)
                {
                    m_CheeseAmount = value;
                    IsDirty = true;
                }
            }
        }

        [SerializeField] private bool m_HasKey;
        public bool HasKey
        {
            get => m_HasKey;
            set
            {
                if (m_HasKey != value)
                {
                    m_HasKey = value;
                    IsDirty = true;
                }
            }
        }

        public MSG_FoodState()
        {
            this.m_FruitAmount = 0;
            this.m_FruitAmount = 0;
            this.Type = MessageType.FruitUpdate;
        }

        public bool IsDirty { get; private set; }

        public void SendUpdate()
        {
            if (ServerConnection.IsAlive && IsDirty)
            {
                IsDirty = false;
                ServerConnection.Send(JsonUtility.ToJson(this));
            }
        }
    }
}
