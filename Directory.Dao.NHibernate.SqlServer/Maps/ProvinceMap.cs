using Directory.Dao.NHibernate.Repo;
using NHibernate.Engine;
using NHibernate.Linq;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Cascade = NHibernate.Mapping.ByCode.Cascade;

namespace Directory.Dao.NHibernate.SqlServer.Maps
{
    public class ProvinceMap : ClassMapping<ProvinceRepo>
    {
        public ProvinceMap()
        {
            this.Table("Province");
            Id(p => p.Id, m => m.Generator(Generators.Native));
            Property(p => p.Name, m =>
            {
                m.NotNullable(true);
                m.Length(20);
            });
            Property(p => p.Code, m =>
            {
                m.NotNullable(true);
                m.Length(20);
            });
            Bag(p => p.Cities,
                map =>
                {
                    map.Key(k => k.Column("ProvinceId"));
                    map.Lazy(CollectionLazy.NoLazy);
                    map.Fetch(CollectionFetchMode.Select);
                    map.Inverse(true);
                    map.Cascade(Cascade.DeleteOrphans);
                   
                }, ce => ce.OneToMany());
        }
    }
}
