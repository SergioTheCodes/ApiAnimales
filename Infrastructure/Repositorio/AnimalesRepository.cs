using Domain.DTO.Animal;
using Infrastructure.Data;
using Infrastructure.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio
{
    public class AnimalesRepository : IAnimalesRepository
    {
        ANIMALESContext c;
        public AnimalesRepository(ANIMALESContext _c)
        {
            _c = c;
        }
        public bool AddAnimal(AnimalDTO animal)
        {
            Animale obj = new Animale
            {
                Animalid = animal.Animalid,
                Birthdate = animal.Birthdate,
                Breed = animal.Breed,
                Name = animal.Name,
                Price = animal.Price,
                Sex = animal.Sex,
                Status = animal.Status,
            };
            try
            {
                c.Animales.Add(obj);
                var rows = c.SaveChanges();
                bool result = (rows > 0);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteAnimal(int animal)
        {
            try
            {
                var todelete = c.Animales.First(e =>e.Animalid == animal);
                if (todelete != null)
                {
                    c.Animales.Remove(todelete);
                }else{
                    return false;
                }
                var rows = c.SaveChanges();
                bool result = (rows > 0);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public AnimalDTO GetAnimal(int id)
        {
            
            try
            {
                var result = c.Animales.First(e => e.Animalid == id);
                AnimalDTO obj = new AnimalDTO
                {
                    Animalid = result.Animalid,
                    Birthdate = result.Birthdate,
                    Breed = result.Breed,
                    Name = result.Name,
                    Price = result.Price,
                    Sex = result.Sex,
                    Status = result.Status
                };
                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool UpdateAnimal(AnimalDTO animal)
        {
            Animale obj = new Animale
            {
                Animalid = animal.Animalid,
                Birthdate = animal.Birthdate,
                Breed = animal.Breed,
                Name = animal.Name,
                Price = animal.Price,
                Sex = animal.Sex,
                Status = animal.Status,
            };
            try
            {
                c.Animales.Add(obj);
                var rows = c.SaveChanges();
                bool result = (rows > 0);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
