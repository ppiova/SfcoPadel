using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SfcoPadel.Data.Courts;
using SfcoPadel.Domain.Courts;

namespace SfcoPadel.UseCases.Courts
{
    public class GetAllCourts
    {
        private CourtsRepository _courtsRepository;

        public GetAllCourts(CourtsRepository courtsRepository)
        {
            _courtsRepository = courtsRepository;
        }

        public Task<IReadOnlyList<Court>> Invoke()
        {
            return _courtsRepository.GetCourtsAsync();
        }
    }
}
