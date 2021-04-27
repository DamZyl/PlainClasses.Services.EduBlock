﻿using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models
{
    public class PlatoonInEduBlock : Entity
    {
        public Guid Id { get; private set; }
        public Guid PlatoonId { get; private set; }
        public Guid EduBlockId { get; private set; }

        #region Ef_Config

        public EduBlock EduBlock { get; set; }

        #endregion

        private PlatoonInEduBlock() { }

        private PlatoonInEduBlock(Guid eduBlockId, Guid platoonId)
        {
            Id = Guid.NewGuid();
            EduBlockId = eduBlockId;
            PlatoonId = platoonId;
        }

        public static PlatoonInEduBlock AddPlatoonToEduBlock(Guid eduBlockId, Guid platoonId)
            => new PlatoonInEduBlock(eduBlockId, platoonId);
    }
}