using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionsTicketType
{
    public static void SeedTicketType(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TicketType>().HasData(
            new TicketType
            {
                Id = 1,
                Price = 10,
                TicketTypeEnum = Domain.Enums.TicketTypeEnum.Single
            },
            new TicketType
            {
                Id = 2,
                Price = 25,
                TicketTypeEnum = Domain.Enums.TicketTypeEnum.Weekly
            },
            new TicketType
            {
                Id = 3,
                Price = 100,
                TicketTypeEnum = Domain.Enums.TicketTypeEnum.Mounthly
            },
            new TicketType
            {
                Id = 4,
                Price = 1000,
                TicketTypeEnum = Domain.Enums.TicketTypeEnum.Annual
            }


            );
    }
}