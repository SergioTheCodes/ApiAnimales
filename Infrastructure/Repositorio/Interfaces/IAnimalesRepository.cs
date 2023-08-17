﻿using Domain.DTO.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Interfaces
{
    public interface IAnimalesRepository
    {
        public bool AddAnimal(AnimalDTO animal);
        public bool UpdateAnimal(AnimalDTO animal);
        public bool DeleteAnimal(int animal);
        public AnimalDTO GetAnimal(int id);
    }
}