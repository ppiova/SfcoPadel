using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SfcoPadel.Domain.Courts;

namespace SfcoPadel.Data.Courts
{
    public class CourtsRepository
    {
        private ICourtsSource _courtsSource;

        public CourtsRepository(ICourtsSource courtsSource)
        {
            _courtsSource = courtsSource;
        }

        public async Task<IReadOnlyList<Court>> GetCourtsAsync()
        {
            return await _courtsSource.GetAll();
        }
    }
}
