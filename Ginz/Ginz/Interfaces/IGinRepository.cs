using Ginz.Model;
using System.Collections.Generic;

namespace Ginz.Interfaces
{
    public interface IGinRepository
    {
        List<Gin> GetGins();
        Gin GetGin(Gin gin);
        void CreateGin(Gin gin);
        void DeleteGin(Gin gin);
        void UpdateGin(Gin gin);

    }
}
