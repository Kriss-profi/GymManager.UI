using GymManager.Application.Dictionaries;
using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionsAnnouncement
{
    public static void SeedAnnouncement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>().HasData(
            new Announcement
            {
                Id = 1,
                Date = new DateTime(2023, 9, 9),
                Description = "Kod promocyjny na suple w sklepie abc = rabat12.",
            },
            new Announcement
            {
                Id = 2,
                Date = new DateTime(2023, 9, 11),
                Description = "W najbliższą Niedzielę Siłownia jest otwarta do godziny 24:00",
            },
            new Announcement
            {
                Id = 3,
                Date = new DateTime(2023, 9, 29),
                Description = "Zatrudnimy Recepcjonistkę",
            },
            new Announcement
            {
                Id = 4,
                Date = new DateTime(2023, 10, 22),
                Description = "Od przyszłego miesiąca kupisz karnet dla dwóch osób w cenie jednego",
            },
            new Announcement
            {
                Id = 5,
                Date = new DateTime(2023, 10, 23),
                Description = "Zatrudnimy trenera personalnego",
            },
            new Announcement
            {
                Id = 6,
                Date = new DateTime(2023, 10, 27),
                Description = "Jutrzejsze zajęcia crossfit zostały odwołane - przepraszamy",
            },
            new Announcement
            {
                Id = 7,
                Date = new DateTime(2023, 10, 29),
                Description = "Kod promocyjny na suple w sklepie abc = rabat12.",
            }
            );
    }
}
