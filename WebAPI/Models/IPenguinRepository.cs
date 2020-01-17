using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IPenguinRepository
    {
         Penguin GetPenguin(Guid ID);

        IEnumerable<Penguin> GetPenguins();
    }
}
