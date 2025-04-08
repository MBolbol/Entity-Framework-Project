
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project1.models
{
    public class STDConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.St_Id);
            builder.Property(x => x.St_Fname).IsRequired().HasMaxLength(255);
        }
    }
}
