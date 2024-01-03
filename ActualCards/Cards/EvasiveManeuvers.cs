using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace ActualCards.Cards {
    class EvasiveManeuvers : CustomCard {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block) {
            block.forceToAdd = -1f;
            statModifiers.health = 1.2f;
            block.cdAdd = 0.25f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats) {
        }


        protected override string GetTitle() {
            return "Evasive Maneuvers";
        }

        protected override string GetDescription() {
            return "Jump backwards when you block.";
        }

        protected override GameObject GetCardArt() {
            return null;
        }

        protected override CardInfo.Rarity GetRarity() {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats() {
            return new CardInfoStat[] {
                new CardInfoStat() {
                    positive = true,
                    stat = "Health",
                    amount = "+20%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme() {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }

        public override string GetModName() {
            return ActualCards.ModInitials;
        }
    }
}