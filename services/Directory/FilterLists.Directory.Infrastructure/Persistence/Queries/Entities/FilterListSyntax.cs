﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSyntax
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; private set; } = null!;
        public int SyntaxId { get; set; }
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListSyntax> builder)
        {
            builder.ToTable(nameof(FilterListSyntax) + "es");
            builder.HasKey(fls => new {fls.FilterListId, fls.SyntaxId});
            builder.HasDataJsonFile<FilterListSyntax>();
        }
    }
}
