using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Directory.Dao.NHibernate.Repo;

namespace Directory.Dao.NHibernate.SqlServer.Maps
{
    public class CityMap : ClassMapping<CityRepo>
    {
        public CityMap()
        {
            this.Table("City");
            Id(p => p.Id, m => m.Generator(Generators.Native));
            Property(p => p.Name, m =>
            {
                m.NotNullable(true);
                m.Length(20);
            });
            ManyToOne(p => p.Province, m =>
            {
                m.Column("ProvinceId");
                m.Cascade(Cascade.None);
                m.Lazy(LazyRelation.NoLazy);
                m.Fetch(FetchKind.Select);
                m.NotNullable(true);
            });
        }
    }
}
