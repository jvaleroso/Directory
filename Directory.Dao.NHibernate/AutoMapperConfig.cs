using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Directory.Dao.NHibernate.Dao;
using Directory.Dao.NHibernate.Repo;

namespace Directory.Dao.NHibernate
{
    public static class AutoMapperConfig
    {
        public static void RegisterTypes()
        {
            Mapper.CreateMap<Province, ProvinceRepo>();
            Mapper.CreateMap<ProvinceRepo, Province>();
            Mapper.CreateMap<City, CityRepo>();
            Mapper.CreateMap<CityRepo, City>();
        }
    }
}
