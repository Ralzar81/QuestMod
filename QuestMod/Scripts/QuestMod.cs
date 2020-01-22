using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using UnityEngine;
using DaggerfallWorkshop.Game.Questing;


namespace QuestMod
{
    public class QuestModMod : MonoBehaviour
    {

        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<QuestModMod>();
        }

        private void Awake()
        {
            InitMod();
            mod.IsReady = true;
        }

        private static void InitMod()
        {
            Debug.Log("QuestMod InitMod");

            QuestListsManager.RegisterQuestList("QuestMod");
               

            Debug.Log("QuestMod QuestList Loaded");

        }
    }
}
