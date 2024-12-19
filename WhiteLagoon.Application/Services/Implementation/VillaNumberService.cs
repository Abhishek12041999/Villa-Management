using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Application.Common.Services.Interface;
using WhiteLagoon.Application.Services.Interface;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Services.Implementation
{
    public class VillaNumbersService : IVillaNumberService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VillaNumbersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        bool IVillaNumberService.CheckVillaNumberExists(int villa_Number)
        {
            return _unitOfWork.VillaNumbers.Any(u => u.Villa_Number == villa_Number);
        }

        void IVillaNumberService.CreateVillaNumber(VillaNumber villaNumber)
        {
            _unitOfWork.VillaNumbers.Add(villaNumber);
            _unitOfWork.Save();
        }

        bool IVillaNumberService.DeleteVillaNumber(int id)
        {
            try
            {
                VillaNumber? objFromDb = _unitOfWork.VillaNumbers.Get(u => u.Villa_Number == id);
                if (objFromDb is not null)
                {
                    _unitOfWork.VillaNumbers.Remove(objFromDb);
                    _unitOfWork.Save();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        IEnumerable<VillaNumber> IVillaNumberService.GetAllVillaNumbers()
        {
            return _unitOfWork.VillaNumbers.GetAll(includeProperties: "Villa");
        }

        VillaNumber IVillaNumberService.GetVillaNumberById(int id)
        {
            return _unitOfWork.VillaNumbers.Get(u => u.Villa_Number == id, includeProperties: "Villa");
        }

        void IVillaNumberService.UpdateVillaNumber(VillaNumber villaNumber)
        {
            _unitOfWork.VillaNumbers.Update(villaNumber);
            _unitOfWork.Save();
        }
    }
}