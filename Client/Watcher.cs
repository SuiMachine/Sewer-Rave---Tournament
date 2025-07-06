using UnityEngine;

namespace SewerSocket
{
    public class Watcher : MonoBehaviour
    {
        public static Watcher Instance { get; private set; }
        private FoodControl foodControl;
        private float delay;
        private Messages.MSG_FoodState LocalFoodCopy;

        public static void Initialize()
        {
            if (Instance != null)
                return;

            GameObject go = new GameObject("WatcherObj");
            DontDestroyOnLoad(go);
            go.hideFlags = HideFlags.HideAndDontSave;
            Instance = go.AddComponent<Watcher>();
        }

        void Start()
        {
            Plugin.Log("Starting socket");
            LocalFoodCopy = new Messages.MSG_FoodState();
            var obj = new Messages.MSG_Reset();
            var serialize = JsonUtility.ToJson(obj);

            ServerConnection.Send(serialize);
        }

        void Update()
        {
            if (delay > 0)
            {
                delay -= Time.deltaTime;
                return;
            }

            if (foodControl == null)
            {
                foodControl = FindObjectOfType<FoodControl>();
                if (foodControl == null)
                {
                    delay = 1f;
                    LocalFoodCopy.FruitAmount = 0;
                    LocalFoodCopy.CheeseAmount = 0;
                    LocalFoodCopy.HasKey = false;
                    if (LocalFoodCopy.IsDirty)
                        LocalFoodCopy.SendUpdate();
                }
                else
                    UpdateFood();
            }
            else
            {
                UpdateFood();
            }
        }

        private void UpdateFood()
        {
            LocalFoodCopy.FruitAmount = foodControl.fruit;
            LocalFoodCopy.CheeseAmount = foodControl.cheese;
            LocalFoodCopy.HasKey = foodControl.haveKey;
            if (LocalFoodCopy.IsDirty)
                LocalFoodCopy.SendUpdate();
        }

        void OnGUI()
        {
            return;
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label($"Fruits: {LocalFoodCopy.FruitAmount} / ");
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

    }
}
