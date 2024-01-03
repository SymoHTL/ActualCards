using UnboundLib.Cards;
using UnityEngine;

namespace ActualCards.Cards {
    public class SniperCard : CustomCard {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block) {
            // remove the spread, increase the damage, and increase the recoil
            gun.spread = 0;
            gun.damage = 2; // +100%
            gun.projectileSpeed = 3; // +200%
            gun.projectileSize *= 0.5f; // -50%
            gun.attackSpeed = 4f; // +300%
            gun.dontAllowAutoFire = true; // no autofire
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
        }

        protected override CardInfoStat[] GetStats() {
            return new CardInfoStat[] {
                new CardInfoStat() {
                    positive = true,
                    stat = "Damage",
                    amount = "+100% (x2)",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat() {
                    positive = true,
                    stat = "Projectile Speed",
                    amount = "+200% (x3)",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat() {
                    positive = true,
                    stat = "Spread",
                    amount = "No",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Auto Fire",
                    amount = "No",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Attack Speed",
                    amount = "+300% (x4)",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Projectile Size",
                    amount = "-50% (x0.5)",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                }
            };
        }

        protected override string GetTitle() {
            return "Sniper";
        }

        protected override string GetDescription() {
            return "Makes your gun a sniper.";
        }

        protected override GameObject GetCardArt() {
            return null;
        }

        protected override CardInfo.Rarity GetRarity() {
            return CardInfo.Rarity.Rare;
        }

        protected override CardThemeColor.CardThemeColorType GetTheme() {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }

        public override string GetModName() {
            return ActualCards.ModInitials;
        }
    }
}