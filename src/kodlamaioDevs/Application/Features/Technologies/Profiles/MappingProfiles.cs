﻿using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Commands.DeleteTechnology;
using Application.Features.Technologies.Commands.UpdateTechnology;
using Application.Features.Technologies.Dtos;
using Application.Features.Technologies.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Technology, TechnologyListDto>()
                .ForMember(c => c.ProgrammingLanguageName, opt => opt.MapFrom(c => c.ProgrammingLanguage.Name))
                .ReverseMap();
            CreateMap<IPaginate<Technology>, TechnologyListModel>().ReverseMap();

            CreateMap<Technology, CreateTechnologyCommand>().ReverseMap();
            CreateMap<Technology, CreatedTechnologyDto>()
                .ForMember(c => c.ProgrammingLanguageId, opt => opt.MapFrom(c => c.ProgrammingLanguage.Id))
                .ReverseMap();

            CreateMap<Technology, DeleteTechnologyCommand>().ReverseMap();
            CreateMap<Technology, DeletedTechnologyDto>()
                .ForMember(c => c.ProgrammingLanguageId, opt => opt.MapFrom(c => c.ProgrammingLanguage.Id))
                .ReverseMap();

            CreateMap<Technology, UpdateTechnologyCommand>().ReverseMap();
            CreateMap<Technology, UpdatedTechnologyDto>()
                .ForMember(c => c.ProgrammingLanguageId, opt => opt.MapFrom(c => c.ProgrammingLanguage.Id))
                .ReverseMap();
        }
    }
}
