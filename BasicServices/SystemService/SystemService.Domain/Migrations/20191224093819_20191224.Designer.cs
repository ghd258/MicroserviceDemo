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
    [Migration("20191224093819_20191224")]
    partial class _20191224
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
                            ID = new Guid("f7524a68-2240-49b4-b30e-debb88ceff45"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "Permission.GetUserMenus",
                            ResourceName = "获取用户菜单",
                            ResourceType = 2,
                            SortNO = 0
                        },
                        new
                        {
                            ID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "ProductMngmt",
                            ResourceName = "产品管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("1f62f061-20a1-493d-83b1-fc14e158b8c9"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "product.list",
                            ResourceName = "列出",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("980e8188-18d2-4d05-b5cd-79880384be12"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "product.get",
                            ResourceName = "获取单个",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("3cd6c00a-abe5-43c6-b58e-72ddde536bc5"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "product.add",
                            ResourceName = "添加",
                            ResourceType = 2,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("f33021a4-3cae-40f1-af19-6c187ac2aecc"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("3cd6c00a-abe5-43c6-b58e-72ddde536bc5"),
                            ResourceCode = "product.add.addbtn",
                            ResourceName = "添加按钮",
                            ResourceType = 3,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("251558f5-b1bd-4785-87f4-c88b30f734f0"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "product.update",
                            ResourceName = "更新",
                            ResourceType = 2,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("5060bc4c-cf5b-409a-b6b8-8a4385e35f20"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "product.delete",
                            ResourceName = "删除",
                            ResourceType = 2,
                            SortNO = 5
                        },
                        new
                        {
                            ID = new Guid("9d05c9be-8f3a-4eb2-a74a-c5170e0d60ab"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("00597049-0235-4582-aa49-5ed181e7e4ce"),
                            ResourceCode = "basket.createorder",
                            ResourceName = "购物车下单",
                            ResourceType = 2,
                            SortNO = 6
                        },
                        new
                        {
                            ID = new Guid("67712b81-1d99-462a-ae6c-3233d48c9e90"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "OrderingMngmt",
                            ResourceName = "订单管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("2b87714d-043a-485b-a356-605ed5561a64"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("67712b81-1d99-462a-ae6c-3233d48c9e90"),
                            ResourceCode = "ordering.add",
                            ResourceName = "新增订单",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("c7c363ca-48cb-4ecf-a22b-9e11793a4b37"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "PaymentMngmt",
                            ResourceName = "支付管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "SystemMngmt",
                            ResourceName = "系统管理",
                            ResourceType = 1,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("0e5501fc-2afa-4c92-b872-6d495f85374f"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
                            ResourceCode = "SystemMngmt.PermissionMngmt",
                            ResourceName = "权限管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("279a4970-6f6e-4e10-9345-cde11ffade89"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("0e5501fc-2afa-4c92-b872-6d495f85374f"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt",
                            ResourceName = "角色管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("d99cb46d-cffa-4a4c-a18e-720820679a93"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("279a4970-6f6e-4e10-9345-cde11ffade89"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Read",
                            ResourceName = "查看",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("ac45cef8-abd7-45e9-9c13-9259e2a7159c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("279a4970-6f6e-4e10-9345-cde11ffade89"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Update",
                            ResourceName = "更改",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("2d756cbd-de72-4e65-b58c-5647f26ce398"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("0e5501fc-2afa-4c92-b872-6d495f85374f"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.ScopeMngmt",
                            ResourceName = "范围管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("7d751a26-ba2b-4d59-928d-d8705502c85c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("0e5501fc-2afa-4c92-b872-6d495f85374f"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.UserMngmt",
                            ResourceName = "用户管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("d1ac524c-967a-4d74-95b9-aa464be4bc2b"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("0e5501fc-2afa-4c92-b872-6d495f85374f"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.AssignmnentMngmt",
                            ResourceName = "授权管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("adf742f1-8a92-4cd0-9814-84fd3a73e4fb"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
                            ResourceCode = "SystemMngmt.JobMngmt",
                            ResourceName = "任务管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("9ae9c077-d7f1-4021-9439-b4e83dc82f82"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
                            ResourceCode = "SystemMngmt.MessageMngmt",
                            ResourceName = "消息管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("a67e5312-5847-48c7-99f7-703384fa0d4a"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
                            ResourceCode = "SystemMngmt.CacheMngmt",
                            ResourceName = "缓存管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("bce2e46e-a4ec-49ed-846d-394c83bc5009"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("b541e964-dcdf-45ee-b5e7-1420327a5f73"),
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
                            ID = new Guid("8b586023-13a5-4917-8ed9-b2205ccc3e4f"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 0,
                            TenantCode = "SYSTEM",
                            TenantLogo = "",
                            TenantName = "SYSTEM",
                            TenantUrl = "www.system.com"
                        },
                        new
                        {
                            ID = new Guid("04ad276b-bf9d-4310-a532-78b7aea6d12e"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 1,
                            TenantCode = "MSFT",
                            TenantLogo = "",
                            TenantName = "Microsoft",
                            TenantUrl = "www.microsoft.com"
                        },
                        new
                        {
                            ID = new Guid("e55538c6-e188-49aa-b05b-e38c63e78eba"),
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