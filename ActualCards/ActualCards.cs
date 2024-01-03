using ActualCards.Cards;
using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace ActualCards {
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("pykess.rounds.plugins.moddingutils")]
    [BepInDependency("com.willis.rounds.modsplus")]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class ActualCards : BaseUnityPlugin {
        private const string ModId = "com.symo.rounds.ActualCardz";
        private const string ModName = "Actual Cardz";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "Actual Cardz";

        public static ActualCards Instance { get; private set; }

        private void Awake() {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        private void Start() {
            Instance = this;
            CustomCard.BuildCard<StoneCard>(); // Repeat for each card to be built
            CustomCard.BuildCard<SniperCard>();
        }
    }
}