﻿using Csv;
using System;
using TitanBot.Downloader;
using TT2Bot.GameEntity.Base;
using TT2Bot.GameEntity.Entities;
using TT2Bot.GameEntity.Enums;
using TT2Bot.GameEntity.Enums.EntityId;
using TT2Bot.Models;

namespace TT2Bot.GameEntity.Services
{
    class EquipmentService : GameEntityService<Equipment>
    {
        protected override string FilePath => "/EquipmentInfo.csv";
        protected override string FileVersion => Settings.FileVersions.Equipment;

        public EquipmentService(Func<TT2GlobalSettings> settings, IDownloader webClient) : base(settings, webClient) { }

        protected override Equipment Build(ICsvLine serverData, string version)
        {
            Enum.TryParse(serverData[0], out EquipmentId id);
            Enum.TryParse(serverData[1], out EquipmentClass eClass);
            Enum.TryParse(serverData[2], out BonusType bonusType);
            Enum.TryParse(serverData[3], out EquipmentRarity rarity);
            double.TryParse(serverData[4], out double bonusBase);
            double.TryParse(serverData[5], out double bonusIncrease);
            Enum.TryParse(serverData[6], out EquipmentSource source);

            return new Equipment(id, eClass, bonusType, rarity, bonusBase, bonusIncrease, source, version, GetImage);
        }
    }
}

