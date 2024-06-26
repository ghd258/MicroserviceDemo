﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SystemService.Domain;

namespace SystemService.Domain.Migrations
{
    [DbContext(typeof(SystemDBContext))]
    [Migration("20191119034026_20191119")]
    partial class _20191119
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ServiceCommon.Recycle", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("DeleteBatchID");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("RowData")
                        .IsRequired();

                    b.Property<Guid>("RowKey");

                    b.Property<string>("TableName")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.ToTable("Recycle");
                });

            modelBuilder.Entity("SystemService.Domain.Resource", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("ParentResourceID");

                    b.Property<string>("ResourceCode")
                        .IsRequired();

                    b.Property<string>("ResourceDesc");

                    b.Property<string>("ResourceName")
                        .IsRequired();

                    b.Property<int>("ResourceType");

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("ID");

                    b.HasIndex("ParentResourceID");

                    b.HasIndex("ResourceCode")
                        .IsUnique();

                    b.ToTable("Resource");

                    b.HasData(
                        new
                        {
                            ID = new Guid("88888888-8888-8888-8888-888888888888"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "RootMenu",
                            ResourceName = "RootMenu",
                            ResourceType = 1,
                            SortNO = 0
                        },
                        new
                        {
                            ID = new Guid("58ff99ee-1ad9-4cfe-8407-74fbb494fff7"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "Permission.GetUserMenus",
                            ResourceName = "获取用户菜单",
                            ResourceType = 2,
                            SortNO = 0
                        },
                        new
                        {
                            ID = new Guid("3feae607-8c67-4870-ad7b-9f7a685d4db8"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "ProductMngmt",
                            ResourceName = "产品管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("d0c9d91d-145d-4941-9a8f-f75083feaf66"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3feae607-8c67-4870-ad7b-9f7a685d4db8"),
                            ResourceCode = "ProductMngmt.Read",
                            ResourceName = "查看",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("ab944839-be7d-4184-98dd-1292011c1a1e"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3feae607-8c67-4870-ad7b-9f7a685d4db8"),
                            ResourceCode = "ProductMngmt.Add",
                            ResourceName = "添加",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("fd87a982-d757-44b6-a2e4-6bba177f2448"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("ab944839-be7d-4184-98dd-1292011c1a1e"),
                            ResourceCode = "ProductMngmt.Add.AddBtn",
                            ResourceName = "添加按钮",
                            ResourceType = 3,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("340baee6-c56e-4b47-8f32-0445a9c3331d"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3feae607-8c67-4870-ad7b-9f7a685d4db8"),
                            ResourceCode = "ProductMngmt.Edit",
                            ResourceName = "修改",
                            ResourceType = 2,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("c4a3567b-bc52-4406-88dd-eac55a31e891"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3feae607-8c67-4870-ad7b-9f7a685d4db8"),
                            ResourceCode = "ProductMngmt.Delete",
                            ResourceName = "删除",
                            ResourceType = 2,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("fd10e54b-2e87-4abc-becd-3b39882413bd"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "OrderingMngmt",
                            ResourceName = "订单管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("85312b0a-fc1f-43a2-8dc6-50266fc99cc1"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "PaymentMngmt",
                            ResourceName = "支付管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "SystemMngmt",
                            ResourceName = "系统管理",
                            ResourceType = 1,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("3c9a3c21-daf2-4653-8034-88ec946d36ca"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            ResourceCode = "SystemMngmt.PermissionMngmt",
                            ResourceName = "权限管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("22f7aaeb-8a5e-448d-a53c-ab8bc11aba79"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3c9a3c21-daf2-4653-8034-88ec946d36ca"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt",
                            ResourceName = "角色管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("ab427912-168e-42d7-8ace-a99b4f3b0e9c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("22f7aaeb-8a5e-448d-a53c-ab8bc11aba79"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Read",
                            ResourceName = "查看",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("253e85e9-35ac-459e-bb5c-662c3e680c3f"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("22f7aaeb-8a5e-448d-a53c-ab8bc11aba79"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Update",
                            ResourceName = "更改",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("3e1ac31b-2459-43ad-b4b7-65c409ac527a"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3c9a3c21-daf2-4653-8034-88ec946d36ca"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.ScopeMngmt",
                            ResourceName = "范围管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("e1a98928-e0d3-413a-b516-c1b9021316e2"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3c9a3c21-daf2-4653-8034-88ec946d36ca"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.UserMngmt",
                            ResourceName = "用户管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("7ed38fa3-6314-43f4-a3c3-9f2a1b4f96ad"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3c9a3c21-daf2-4653-8034-88ec946d36ca"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.AssignmnentMngmt",
                            ResourceName = "授权管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("17c7f6f9-0d34-4b16-9e6a-3b05638b8afe"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            ResourceCode = "SystemMngmt.JobMngmt",
                            ResourceName = "任务管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("2ce185a5-8095-4276-90b8-d4554682851e"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            ResourceCode = "SystemMngmt.MessageMngmt",
                            ResourceName = "消息管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("8c0debaa-33a9-421e-b29a-a2da0cb4ce78"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            ResourceCode = "SystemMngmt.CacheMngmt",
                            ResourceName = "缓存管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("7d64baf8-43a0-4c02-bf66-c13a91fb0198"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("eee46887-62a2-4d55-b8cf-77c096339d14"),
                            ResourceCode = "SystemMngmt.LogMngmt",
                            ResourceName = "日志管理",
                            ResourceType = 1,
                            SortNO = 4
                        });
                });

            modelBuilder.Entity("SystemService.Domain.Tenant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("SortNO");

                    b.Property<string>("TenantCode")
                        .IsRequired();

                    b.Property<string>("TenantDesc");

                    b.Property<string>("TenantLogo")
                        .IsRequired();

                    b.Property<string>("TenantName")
                        .IsRequired();

                    b.Property<string>("TenantUrl")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("ID");

                    b.HasIndex("TenantCode")
                        .IsUnique();

                    b.ToTable("Tenant");

                    b.HasData(
                        new
                        {
                            ID = new Guid("52695b8c-6033-4e22-b177-a70838a5f69c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 0,
                            TenantCode = "SYSTEM",
                            TenantLogo = "",
                            TenantName = "SYSTEM",
                            TenantUrl = "www.system.com"
                        },
                        new
                        {
                            ID = new Guid("b6abe819-c9f8-48ed-8fa2-d28faf7557b4"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 1,
                            TenantCode = "MSFT",
                            TenantLogo = "",
                            TenantName = "Microsoft",
                            TenantUrl = "www.microsoft.com"
                        },
                        new
                        {
                            ID = new Guid("b11547c4-8dd7-4184-b3a8-96a9f3a7b955"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 2,
                            TenantCode = "GOOG",
                            TenantLogo = "",
                            TenantName = "Google",
                            TenantUrl = "www.Google.com"
                        });
                });

            modelBuilder.Entity("SystemService.Domain.Resource", b =>
                {
                    b.HasOne("SystemService.Domain.Resource", "ParentResource")
                        .WithMany("ChildrenResources")
                        .HasForeignKey("ParentResourceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
