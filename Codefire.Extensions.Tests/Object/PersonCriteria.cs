using System.Linq;

namespace Codefire.Extensions.Tests
{
    public class PersonCriteria : ICriteria<Person>
    {
        public string Name { get; set; }
        public bool? IsEmployed { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }

        public IQueryable<Person> Apply(IQueryable<Person> qry)
        {
            if (!string.IsNullOrEmpty(Name))
                qry = qry.Where(x => x.Name.StartsWith(Name));

            if (IsEmployed != null)
                qry = qry.Where(x => x.IsEmployed == IsEmployed);

            if (FromAge != null)
                qry = qry.Where(x => x.Age >= FromAge);

            if (ToAge != null)
                qry = qry.Where(x => x.Age <= ToAge);

            return qry;
        }
    }
}
