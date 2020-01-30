﻿using System.Collections.Generic;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Models
{
    public class SectionViewModel:INamedEntity,IOrderedEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public List<SectionViewModel> ChildSections { get; set; }
        public SectionViewModel Parentsection { get; set; }
    }
}