using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SfcoPadel.Domain.Courts;

namespace SfcoPadel.Data.Courts
{
    public interface ICourtsSource
    {
        Task<IReadOnlyList<Court>> GetAll();
    }
}
