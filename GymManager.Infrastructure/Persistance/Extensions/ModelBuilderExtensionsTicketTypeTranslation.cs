using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionsTicketTypeTranslation
{
    public static void SeedTicketTypeTranslation(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TicketTypeTranslation>().HasData(
            new TicketTypeTranslation
            {
                Id = 1,
                LanguageId = 1, 
                Name = "Jednorazowy",
                TicketTypeId = 1
            },
            new TicketTypeTranslation
            {
                Id = 2,
                LanguageId = 2,
                Name = "Single",
                TicketTypeId = 1
            },
            new TicketTypeTranslation
            {
                Id = 3,
                LanguageId = 3,
                Name = "Einzel",
                TicketTypeId = 1
            },
            new TicketTypeTranslation
            {
                Id = 4,
                LanguageId = 1,
                Name = "Tygodniowy",
                TicketTypeId = 2
            },
            new TicketTypeTranslation
            {
                Id = 5,
                LanguageId = 2,
                Name = "Weekly",
                TicketTypeId = 2
            },
            new TicketTypeTranslation
            {
                Id = 6,
                LanguageId = 3,
                Name = "Wöchentlich",
                TicketTypeId = 2
            },
            new TicketTypeTranslation
            {
                Id = 7,
                LanguageId = 1,
                Name = "Miesięczny",
                TicketTypeId = 3
            },
            new TicketTypeTranslation
            {
                Id = 8,
                LanguageId = 2,
                Name = "Monthly",
                TicketTypeId = 3
            },
            new TicketTypeTranslation
            {
                Id = 9,
                LanguageId = 3,
                Name = "Monatlich",
                TicketTypeId = 3
            },
            new TicketTypeTranslation
            {
                Id = 10,
                LanguageId = 1,
                Name = "Roczny",
                TicketTypeId = 4
            },
            new TicketTypeTranslation
            {
                Id = 11,
                LanguageId = 2,
                Name = "Annual",
                TicketTypeId = 4
            },
            new TicketTypeTranslation
            {
                Id = 12,
                LanguageId = 3,
                Name = "Jährlich",
                TicketTypeId = 4
            }
            );
    }
}