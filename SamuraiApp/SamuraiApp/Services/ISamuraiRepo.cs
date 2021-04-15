using SamuraiApp.Models;
using System.Collections.Generic;

namespace SamuraiApp.Services
{
    public interface ISamuraiRepo
    {
        List<Samurai> GetAllSamurais();

        void AddSamurai(Samurai samurai);
    }
}