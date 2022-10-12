using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SkillsLab : IIntern
    {
        private string Name { get; set; }
        private int Id { get; set; }
        public string NameId => $"SkillsLab - {Name}: {Id}";

       //public string NameId
       //{
       //    get
       //    {
       //        return $"SkillsLab - {Name} : {Id}";
       //    }
       //}

        public SkillsLab(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string GetNameId()
        {
            return NameId;
        }
    }
}
