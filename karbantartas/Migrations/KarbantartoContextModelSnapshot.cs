// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using karbantartas.Models;

#nullable disable

namespace karbantartas.Migrations
{
    [DbContext(typeof(KarbantartoContext))]
    partial class KarbantartoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("karbantartas.Models.Anyagszukseglet", b =>
                {
                    b.Property<long?>("a_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("a_db")
                        .HasColumnType("bigint");

                    b.Property<string>("a_nev")
                        .HasColumnType("longtext");

                    b.Property<long?>("f_id_ikf_id")
                        .HasColumnType("bigint");

                    b.HasKey("a_id");

                    b.HasIndex("f_id_ikf_id");

                    b.ToTable("Anyagszukseglet");
                });

            modelBuilder.Entity("karbantartas.Models.Feladatok", b =>
                {
                    b.Property<long?>("f_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("f_nev")
                        .HasColumnType("longtext");

                    b.Property<string>("leiras")
                        .HasColumnType("longtext");

                    b.HasKey("f_id");

                    b.ToTable("Feladatok");
                });

            modelBuilder.Entity("karbantartas.Models.Karbantartasok", b =>
                {
                    b.Property<long?>("k_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("f_id_ikf_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("k_kezd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("k_tipus")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("k_vege")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("karb_id_ikk_id")
                        .HasColumnType("bigint");

                    b.HasKey("k_id");

                    b.HasIndex("f_id_ikf_id");

                    b.HasIndex("karb_id_ikk_id");

                    b.ToTable("Karbantartasok");
                });

            modelBuilder.Entity("karbantartas.Models.Karbantartok", b =>
                {
                    b.Property<long?>("karb_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("karb_beoszt")
                        .HasColumnType("longtext");

                    b.Property<long?>("karb_fiz")
                        .HasColumnType("bigint");

                    b.Property<string>("karb_nev")
                        .HasColumnType("longtext");

                    b.Property<string>("karb_tipus")
                        .HasColumnType("longtext");

                    b.HasKey("karb_id");

                    b.ToTable("Karbantartok");
                });

            modelBuilder.Entity("karbantartas.Models.Anyagszukseglet", b =>
                {
                    b.HasOne("karbantartas.Models.Feladatok", "f_id_ik")
                        .WithMany()
                        .HasForeignKey("f_id_ikf_id");

                    b.Navigation("f_id_ik");
                });

            modelBuilder.Entity("karbantartas.Models.Karbantartasok", b =>
                {
                    b.HasOne("karbantartas.Models.Feladatok", "f_id_ik")
                        .WithMany()
                        .HasForeignKey("f_id_ikf_id");

                    b.HasOne("karbantartas.Models.Karbantartasok", "karb_id_ik")
                        .WithMany()
                        .HasForeignKey("karb_id_ikk_id");

                    b.Navigation("f_id_ik");

                    b.Navigation("karb_id_ik");
                });
#pragma warning restore 612, 618
        }
    }
}
