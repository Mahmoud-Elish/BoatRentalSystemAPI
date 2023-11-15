using AutoMapper;
using BoatRental.DAL;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.BL;

public class BoatService : IBoatService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BoatService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task AddAsync(BoatAddDto boat)
    {
        try
        {
             var newBoat = _mapper.Map<Boat>(boat);
             await _unitOfWork.BoatRepo.AddAsync(newBoat);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
