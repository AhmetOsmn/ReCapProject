﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : ICarRentalService<Color>
    {
        ICarRentalDal<Color> _colorDal;

        public ColorManager(ICarRentalDal<Color> carRentalDal)
        {
            _colorDal = carRentalDal;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.GetById(id);
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}