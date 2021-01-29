using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnlineShop.Models
{
    public partial class AppContext : DbContext
    {
        public AppContext()
        {
        }

        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssembledCase> AssembledCases { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyProduct> CompanyProducts { get; set; }
        public virtual DbSet<ComputerAccessory> ComputerAccessories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ExternalHard> ExternalHards { get; set; }
        public virtual DbSet<Keyboard> Keyboards { get; set; }
        public virtual DbSet<Laptop> Laptops { get; set; }
        public virtual DbSet<Mobile> Mobiles { get; set; }
        public virtual DbSet<MobileAccessory> MobileAccessories { get; set; }
        public virtual DbSet<MobileCover> MobileCovers { get; set; }
        public virtual DbSet<MobileHolder> MobileHolders { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Powerbank> Powerbanks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AssembledCase>(entity =>
            {
                entity.ToTable("assembled_case");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CaseType)
                    .HasMaxLength(50)
                    .HasColumnName("case_type");

                entity.Property(e => e.Cpu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cpu");

                entity.Property(e => e.Ram).HasColumnName("ram");

                entity.Property(e => e.Storage).HasColumnName("storage");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.AssembledCase)
                    .HasForeignKey<AssembledCase>(d => d.Id)
                    .HasConstraintName("FK__assembled_ca__id__4316F928");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CertificateNumber)
                    .HasName("PK__company__435926495BD57075");

                entity.ToTable("company");

                entity.Property(e => e.CertificateNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("certificate_number");

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("company_address");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("company_name");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<CompanyProduct>(entity =>
            {
                entity.ToTable("company_product");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyProducts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__company_p__compa__5CD6CB2B");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CompanyProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__company_p__produ__5DCAEF64");
            });

            modelBuilder.Entity<ComputerAccessory>(entity =>
            {
                entity.ToTable("computer_accessories");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ComputerAccessory)
                    .HasForeignKey<ComputerAccessory>(d => d.Id)
                    .HasConstraintName("FK__computer_acc__id__3D5E1FD2");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdSsn)
                    .HasName("PK__customer__6D6CD4E28739C97D");

                entity.ToTable("customer");

                entity.Property(e => e.IdSsn)
                    .ValueGeneratedNever()
                    .HasColumnName("id_ssn");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<ExternalHard>(entity =>
            {
                entity.ToTable("external_hard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Storage).HasColumnName("storage");

                entity.Property(e => e.StorageNoe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("storage_noe");

                entity.Property(e => e.WaterProof).HasColumnName("water_proof");

                entity.Property(e => e.WaterResisdent).HasColumnName("water_resisdent");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ExternalHard)
                    .HasForeignKey<ExternalHard>(d => d.Id)
                    .HasConstraintName("FK__external_har__id__4BAC3F29");
            });

            modelBuilder.Entity<Keyboard>(entity =>
            {
                entity.ToTable("keyboard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BackgroundLight).HasColumnName("background_light");

                entity.Property(e => e.HeadsetPort)
                    .HasColumnName("headset_port")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersianWords).HasColumnName("persian_words");

                entity.Property(e => e.UsbPort)
                    .HasColumnName("usb_port")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterProof)
                    .HasColumnName("water_proof")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Keyboard)
                    .HasForeignKey<Keyboard>(d => d.Id)
                    .HasConstraintName("FK__keyboard__id__45F365D3");
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.ToTable("laptop");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Cpu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cpu");

                entity.Property(e => e.Gpu).HasColumnName("gpu");

                entity.Property(e => e.GpuBrand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("gpu_brand");

                entity.Property(e => e.LaptopType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("laptop_type");

                entity.Property(e => e.MateScreen).HasColumnName("mate_screen");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("os");

                entity.Property(e => e.Ram).HasColumnName("ram");

                entity.Property(e => e.RamType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ram_type");

                entity.Property(e => e.Resuloution)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("resuloution");

                entity.Property(e => e.ScreenSize).HasColumnName("screen_size");

                entity.Property(e => e.Storage).HasColumnName("storage");

                entity.Property(e => e.TouchScreen).HasColumnName("touch_screen");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Laptop)
                    .HasForeignKey<Laptop>(d => d.Id)
                    .HasConstraintName("FK__laptop__id__29572725");
            });

            modelBuilder.Entity<Mobile>(entity =>
            {
                entity.ToTable("mobile");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Camera).HasColumnName("camera");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Network)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("network");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("os");

                entity.Property(e => e.Procceessor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("procceessor");

                entity.Property(e => e.Ram).HasColumnName("ram");

                entity.Property(e => e.Resuloution)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("resuloution");

                entity.Property(e => e.ScreenSize).HasColumnName("screen_size");

                entity.Property(e => e.Storage).HasColumnName("storage");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Mobile)
                    .HasForeignKey<Mobile>(d => d.Id)
                    .HasConstraintName("FK__mobile__id__2C3393D0");
            });

            modelBuilder.Entity<MobileAccessory>(entity =>
            {
                entity.ToTable("mobile_accessories");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.MobileAccessory)
                    .HasForeignKey<MobileAccessory>(d => d.Id)
                    .HasConstraintName("FK__mobile_acces__id__2F10007B");
            });

            modelBuilder.Entity<MobileCover>(entity =>
            {
                entity.ToTable("mobile_cover");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.CoverType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cover_type");

                entity.Property(e => e.MobileBrand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mobile_brand");

                entity.Property(e => e.MobileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mobile_name");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .HasColumnName("speciality");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.MobileCover)
                    .HasForeignKey<MobileCover>(d => d.Id)
                    .HasConstraintName("FK__mobile_cover__id__37A5467C");
            });

            modelBuilder.Entity<MobileHolder>(entity =>
            {
                entity.ToTable("mobile_holder");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Chargable)
                    .HasColumnName("chargable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Charger)
                    .HasColumnName("charger")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HolderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("holder_type");

                entity.Property(e => e.Speaker)
                    .HasColumnName("speaker")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.MobileHolder)
                    .HasForeignKey<MobileHolder>(d => d.Id)
                    .HasConstraintName("FK__mobile_holde__id__31EC6D26");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.ToTable("monitor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BackgroundColor)
                    .HasMaxLength(50)
                    .HasColumnName("background_color");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.DviPort).HasColumnName("dvi_port");

                entity.Property(e => e.Fps).HasColumnName("fps");

                entity.Property(e => e.HtmiPort).HasColumnName("htmi_port");

                entity.Property(e => e.Panel)
                    .HasMaxLength(50)
                    .HasColumnName("panel");

                entity.Property(e => e.Resuloution)
                    .HasMaxLength(50)
                    .HasColumnName("resuloution");

                entity.Property(e => e.ScreenSize).HasColumnName("screen_size");

                entity.Property(e => e.Speaker).HasColumnName("speaker");

                entity.Property(e => e.UsbPort).HasColumnName("usb_port");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Monitor)
                    .HasForeignKey<Monitor>(d => d.Id)
                    .HasConstraintName("FK__monitor__id__403A8C7D");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("photo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Photo1)
                    .IsRequired()
                    .HasColumnName("Photo");
            });

            modelBuilder.Entity<Powerbank>(entity =>
            {
                entity.ToTable("powerbank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.IIn).HasColumnName("i_in");

                entity.Property(e => e.IOut).HasColumnName("i_out");

                entity.Property(e => e.PortNumber).HasColumnName("port_number");

                entity.Property(e => e.VIn).HasColumnName("v_in");

                entity.Property(e => e.VOut).HasColumnName("v_out");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Powerbank)
                    .HasForeignKey<Powerbank>(d => d.Id)
                    .HasConstraintName("FK__powerbank__id__3A81B327");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("brand");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FastShipping).HasColumnName("fast_shipping");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductWeight).HasColumnName("product_weight");

                entity.Property(e => e.Promotion)
                    .HasMaxLength(50)
                    .HasColumnName("promotion");

                entity.Property(e => e.SalesNumber)
                    .HasColumnName("sales_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("size");

                entity.Property(e => e.SpecialOffer)
                    .HasColumnName("special_offer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("reviews");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Discription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("discription");

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Strengths)
                    .HasMaxLength(50)
                    .HasColumnName("strengths");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UesrId).HasColumnName("uesr_id");

                entity.Property(e => e.Weaknesses)
                    .HasMaxLength(50)
                    .HasColumnName("weaknesses");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("FK__reviews__photo_i__5629CD9C");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reviews__product__5535A963");

                entity.HasOne(d => d.Uesr)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UesrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reviews__uesr_id__5441852A");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchase_date");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UesrId).HasColumnName("uesr_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sales__product_i__59FA5E80");

                entity.HasOne(d => d.Uesr)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.UesrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sales__uesr_id__59063A47");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
