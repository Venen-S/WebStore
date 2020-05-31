using WebStore.Domain.DTO.Products;
using WebStore.Domain.Entities;

namespace WebStoreServices.Mapping
{
    public static class SectionMapping
    {
        public static SectionDTO ToDTO(this Section Section) => Section is null
            ? null
            : new SectionDTO()
            {
                Id = Section.Id,
                Name = Section.Name,
            };

        public static Section FromDTO(this SectionDTO Section) => Section is null
            ? null
            : new Section()
            {
                Id = Section.Id,
                Name = Section.Name,
            };
    }
}