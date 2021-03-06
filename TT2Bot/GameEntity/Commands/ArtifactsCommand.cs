﻿using System;
using System.Threading.Tasks;
using TitanBot.Commands;
using TT2Bot.GameEntity.Base;
using TT2Bot.GameEntity.Embedables;
using TT2Bot.GameEntity.Entities;
using TT2Bot.Services;
using static TT2Bot.TT2Localisation.Help;

namespace TT2Bot.GameEntity.Commands
{
    [Description(Desc.ARTIFACT), Group("Data")]
    [Alias("Art", "Arts", "Artifact")]
    internal class ArtifactsCommand : GameEntityCommand
    {
        public ArtifactsCommand(TT2DataService dataService) : base(dataService)
        {
        }

        [Call, Alias("List")]
        [Usage(Usage.ARTIFACT_LIST)]
        private async Task ListArtifactsAsync()
            => await ReplyAsync(new ArtifactListEmbedable(Context, DataService.Artifacts));

        [Call("Budget")]
        [Usage(Usage.ARTIFACT_BUDGET)]
        private Task GetBudgetAsync([Dense]Artifact artifact, double relics, int currentLevel = 0)
        {
            relics = relics.Clamp(0, double.MaxValue);
            currentLevel = currentLevel.Clamp(0, artifact.MaxLevel ?? int.MaxValue);
            return ShowArtifactAsync(artifact, currentLevel, artifact.BudgetArtifact(relics, currentLevel));
        }

        [Call]
        [Usage(Usage.ARTIFACT)]
        private async Task ShowArtifactAsync([Dense]Artifact artifact, int? from = null, int? to = null)
            => await ReplyAsync(new ArtifactSingleEmbedable(Context, artifact, from, to));
    }
}