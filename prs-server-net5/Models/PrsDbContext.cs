using Microsoft.EntityFrameworkCore;

using prs_server_net5.Models;

public class PrsDbContext : DbContext {

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Vendor> Vendors { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Request> Requests { get; set; }
    public virtual DbSet<Requestline> Requestlines { get; set; }

    public PrsDbContext(DbContextOptions<PrsDbContext> options)
        : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<User>(e => {
            e.HasIndex(p => p.Username).IsUnique(true);
        });
        builder.Entity<Vendor>(e => {
            e.HasIndex(p => p.Code).IsUnique(true);
        });
        builder.Entity<Product>(e => {
            e.HasIndex(p => p.PartNbr).IsUnique(true);
        });
        builder.Entity<Request>(e => {

        });
        builder.Entity<Requestline>(e => {
            
        });
    }
}