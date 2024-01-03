using UnboundLib.Cards;
using UnityEngine;

namespace ActualCards.Cards {
    public class StoneCard : CustomCard {
        protected override string GetTitle() {
            return "Be the Stone";
        }

        protected override string GetDescription() {
            return "You are a stone.";
        }
        
        public override string GetModName() {
            return ActualCards.ModInitials;
        }

        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block) {
            statModifiers.health = 5;
            statModifiers.movementSpeed = 0.1f;
        }

        protected override CardInfoStat[] GetStats() {
            return new CardInfoStat[] {
                new CardInfoStat() {
                    positive = true,
                    stat = "Health",
                    amount = "+400% (x5)",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "-90% (x0.1)",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                }
            };
        }

        protected override CardInfo.Rarity GetRarity() {
            return CardInfo.Rarity.Rare;
        }

        protected override GameObject GetCardArt() {
            return null;
        }

        protected override CardThemeColor.CardThemeColorType GetTheme() {
            return CardThemeColor.CardThemeColorType.TechWhite;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity,
            Block block, CharacterStatModifiers characterStats) {
        }
    }
}