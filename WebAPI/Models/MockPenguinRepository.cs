using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class MockPenguinRepository : IPenguinRepository
    {

        private List<Penguin> _penguinList;

        public MockPenguinRepository()
        {
            _penguinList = new List<Penguin>() {
                new Penguin(){ Id = new Guid("7110cd13-1882-4504-96f4-cb4b456894fb"), Name = "Jhon", Age = 12, Gender = Gender.Female, Genus = Genus.Aptenodytes },
                new Penguin(){ Id = new Guid("e551576a-91ce-4cd2-831e-26fd10cc88a0"), Name = "Doe", Age = 15, Gender = Gender.Helicopter, Genus = Genus.Eudyptes },
                new Penguin(){ Id = new Guid("b90c4e5b-fad8-4c54-93db-6bb68c1bb13a"), Name = "Marry", Age = 16, Gender = Gender.Male, Genus = Genus.Pygoscelis }
            };
        }

        public IEnumerable<Penguin> GetPenguins()
        {
            return _penguinList;
        }

        public Penguin GetPenguin(Guid Id)
        {
            return _penguinList.FirstOrDefault(e => e.Id == Id);

            
        }


    }
}
