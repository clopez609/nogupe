﻿using AutoMapper;
using Nogupe.Web.Common;
using Nogupe.Web.Entities.Courses;
using Nogupe.Web.Services.Ratings.DTOs;
using Nogupe.Web.ViewModels;
using Nogupe.Web.ViewModels.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nogupe.Web.Mappings
{
    public static class RatingMapper
    {
        private static readonly IMapper Mapper;

        static RatingMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RatingViewModel, Rating>();
                    //.ForMember(opt => opt.UserId, dst => dst.Ignore());

                cfg.CreateMap<RatingListDTO, RatingViewModel>();

                cfg.CreateMap<IEnumerable<Rating>, IEnumerable<RatingViewModel>>();

                cfg.CreateMap<Rating, RatingViewModel>()
                    .ForMember(dst => dst.Username, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"));

                cfg.CreateMap<Rating, RatingDetailViewModel>();

                cfg.CreateMap(typeof(PagedListResult<RatingListDTO>), typeof(PagedListResultViewModel<RatingViewModel>));
            });

            Mapper = config.CreateMapper();
        }

        public static Rating ToEntityModel(this RatingViewModel ratingListViewModel, Rating rating)
        {
            return Mapper.Map(ratingListViewModel, rating);
        }

        public static IEnumerable<RatingViewModel> ToViewModel(this IEnumerable<Rating> ratings)
        {
            return Mapper.Map<IEnumerable<RatingViewModel>>(ratings);
        }

        public static RatingDetailViewModel ToDetailViewModel(this Rating rating)
        {
            var ratingViewModel = Mapper.Map<RatingDetailViewModel>(rating);

            ratingViewModel.Status = rating.Status.ToString() == "Regular" 
                ? "Regular": rating.Status.ToString() == "Postponed" 
                ? "Aplazado" : rating.Status.ToString() == "Promotion" 
                ? "Promociona" : "Sin notas" ;

            return ratingViewModel;
        }

        public static PagedListResultViewModel<RatingViewModel> ToViewModel(
            this PagedListResult<RatingListDTO> ratings)
        {
            return Mapper.Map<PagedListResultViewModel<RatingViewModel>>(ratings);
        }
    }
}
