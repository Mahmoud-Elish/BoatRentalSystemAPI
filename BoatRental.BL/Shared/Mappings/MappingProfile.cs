using AutoMapper;
using BoatRental.DAL;


namespace BoatRental.BL;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //CreateMap<EventDateTime, DateTime>().ConvertUsing(src => src.DateTime ?? DateTime.MinValue);
        CreateMap<BoatAddDto, Boat>();
        //CreateMap<GoogleCalendarDto, Event>()
        //   .ForMember(dest => dest.Start, opt => opt.MapFrom(src => new EventDateTime
        //   {
        //       DateTime = src.Start,
        //       TimeZone = "Africa/Cairo"
        //   }))
        //   .ForMember(dest => dest.End, opt => opt.MapFrom(src => new EventDateTime
        //   {
        //       DateTime = src.End,
        //       TimeZone = "Africa/Cairo"
        //   }));
    }
}

