﻿using AutoMapper;
using PiensaPeruAPIWeb.Domain.Models.Contents;
using PiensaPeruAPIWeb.Resources.Contents;

namespace PiensaPeruAPIWeb.Mapping.Contents
{
    public class PoliticalPartyToPoliticalPartyReProfile : Profile
    {
        public PoliticalPartyToPoliticalPartyReProfile()
        {
            CreateMap<PoliticalParty, PoliticalPartyResource>();
        }
    }
}