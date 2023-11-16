﻿using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = GymManager.Domain.Entities.File;

namespace GymManager.Application.Common.Interfaces
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<Announcement> Announcements { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<EmployeeEvent> EmployeeEvents { get; set; }
        DbSet<File> Files { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Settings> Settings { get; set; }
        DbSet<SettingsPosition> SettingsPositions { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        DbSet<TicketType> TicketTypes { get; set; }
        DbSet<TicketTypeTranslation> TicketTypesTranslations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
