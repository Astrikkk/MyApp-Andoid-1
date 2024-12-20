﻿using AutoMapper;
using AndoidAppAPI.Data.Entities;
using AndoidAppAPI.Models.Category;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AndoidAppAPI.Mapper
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            //Початок
            CreateMap<CategoryEntity, CategoryItemModel>()
                .ForMember(x => x.ImagePath, opt => opt.MapFrom(x =>
                    string.IsNullOrEmpty(x.Image) ? "/images/noimage.jpg" : $"/images/{x.Image}"));

            CreateMap<CategoryCreateModel, CategoryEntity>()
                .ForMember(x => x.Image, opt => opt.Ignore());
        }
    }
}