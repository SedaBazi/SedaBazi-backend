using Microsoft.EntityFrameworkCore;
using SedaBazi.Domain.Entities.Audios;
using SedaBazi.Domain.Entities.Managements;
using SedaBazi.Domain.Entities.Users;
using System.Threading;
using System.Threading.Tasks;

namespace SedaBazi.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }

        DbSet<AudioCollection> AudioCollections { get; set; }

        DbSet<Audio> Audios { get; set; }

        DbSet<Management> Managements { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
