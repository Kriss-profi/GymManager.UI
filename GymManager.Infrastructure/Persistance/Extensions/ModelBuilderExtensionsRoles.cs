using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionsRoles
{
    public static void SeedRoles(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "FE740916-18C7-42AD-924C-273B76FEF837",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "E2CE3CEA-BA77-4E87-BED8-BA46D7E6A776"
            },
            new IdentityRole
            {
                Id = "FE2AF78F-4353-4363-A6E6-3F1A9AD5331C",
                Name = "Klient",
                NormalizedName = "KLIENT",
                ConcurrencyStamp = "2DD6F477-B941-4BCC-A943-F8A6C5D1F36C"
            },
            new IdentityRole
            {
                Id = "1D3FF174-2637-4B36-82BF-86F894C9090D",
                Name = "Pracownik",
                NormalizedName = "PRACOWNIK",
                ConcurrencyStamp = "26B7CC9C-74D2-45D4-9FC2-BA22A045842D"
            }
            );
            
    }
}
