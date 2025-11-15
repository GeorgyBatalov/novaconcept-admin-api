using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CmsCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    PictureUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsCategories_CmsCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "CmsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CmsMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CmsPhotoGalleries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    CoverImageUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsPhotoGalleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderNumber = table.Column<string>(type: "text", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: true),
                    CustomerPhone = table.Column<string>(type: "text", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    IpAddress = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorStepPropertyGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorStepPropertyGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorStepPropertyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorStepPropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorSteps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCategories_ShopCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "ShopCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopDeliveries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<decimal>(type: "numeric", nullable: true),
                    FreeFromAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    EstimatedTime = table.Column<string>(type: "text", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDeliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopDiscountTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDiscountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrderStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    IsFinal = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopPaymentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductPropertyGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductPropertyGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductVendors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LogoUrl = table.Column<string>(type: "text", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "text", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductVendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CmsNewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    Tags = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Keywords = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PictureUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShowComments = table.Column<bool>(type: "boolean", nullable: false),
                    CmsCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmsPhotoGalleryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsNewsItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsNewsItems_CmsCategories_CmsCategoryId",
                        column: x => x.CmsCategoryId,
                        principalTable: "CmsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CmsNewsItems_CmsPhotoGalleries_CmsPhotoGalleryId",
                        column: x => x.CmsPhotoGalleryId,
                        principalTable: "CmsPhotoGalleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CmsPages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    Tags = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    MasterPage = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Keywords = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ShowBreadcrumbs = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    ShowComments = table.Column<bool>(type: "boolean", nullable: false),
                    IsFrontPage = table.Column<bool>(type: "boolean", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    PictureUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    CmsCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmsPhotoGalleryId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsPages_CmsCategories_CmsCategoryId",
                        column: x => x.CmsCategoryId,
                        principalTable: "CmsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CmsPages_CmsPhotoGalleries_CmsPhotoGalleryId",
                        column: x => x.CmsPhotoGalleryId,
                        principalTable: "CmsPhotoGalleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CmsPhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    ImageUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CmsPhotoGalleryId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsPhotos_CmsPhotoGalleries_CmsPhotoGalleryId",
                        column: x => x.CmsPhotoGalleryId,
                        principalTable: "CmsPhotoGalleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorStepProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    ConstructorStepId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConstructorStepPropertyTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ConstructorStepPropertyGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorStepProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstructorStepProperties_ConstructorStepPropertyGroups_Con~",
                        column: x => x.ConstructorStepPropertyGroupId,
                        principalTable: "ConstructorStepPropertyGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConstructorStepProperties_ConstructorStepPropertyTypes_Cons~",
                        column: x => x.ConstructorStepPropertyTypeId,
                        principalTable: "ConstructorStepPropertyTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConstructorStepProperties_ConstructorSteps_ConstructorStepId",
                        column: x => x.ConstructorStepId,
                        principalTable: "ConstructorSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopDiscounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PromoCode = table.Column<string>(type: "text", nullable: true),
                    ShopDiscountTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    DiscountValue = table.Column<decimal>(type: "numeric", nullable: false),
                    MinOrderAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MaxUsageCount = table.Column<int>(type: "integer", nullable: true),
                    UsageCount = table.Column<int>(type: "integer", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopDiscounts_ShopDiscountTypes_ShopDiscountTypeId",
                        column: x => x.ShopDiscountTypeId,
                        principalTable: "ShopDiscountTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopProductProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShopProductPropertyGroupId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductProperties_ShopProductPropertyGroups_ShopProduct~",
                        column: x => x.ShopProductPropertyGroupId,
                        principalTable: "ShopProductPropertyGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Quantity = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Url = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    PictureUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    Keywords = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Tags = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Article = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Weight = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Length = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Width = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ShopProductVendorId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProducts_ShopProductVendors_ShopProductVendorId",
                        column: x => x.ShopProductVendorId,
                        principalTable: "ShopProductVendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CmsMenuItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    CssClass = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IconClass = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OpenInNewWindow = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CmsMenuId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmsPageId = table.Column<Guid>(type: "uuid", nullable: true),
                    ParentMenuItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsMenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsMenuItems_CmsMenuItems_ParentMenuItemId",
                        column: x => x.ParentMenuItemId,
                        principalTable: "CmsMenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmsMenuItems_CmsMenus_CmsMenuId",
                        column: x => x.CmsMenuId,
                        principalTable: "CmsMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CmsMenuItems_CmsPages_CmsPageId",
                        column: x => x.CmsPageId,
                        principalTable: "CmsPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorStepPropertyAvailableValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PriceModifier = table.Column<decimal>(type: "numeric", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ConstructorStepPropertyId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorStepPropertyAvailableValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstructorStepPropertyAvailableValues_ConstructorStepPrope~",
                        column: x => x.ConstructorStepPropertyId,
                        principalTable: "ConstructorStepProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerName = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CustomerEmail = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CustomerPhone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeliveryAddress = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DeliveryCost = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    FinalAmount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IpAddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UserAgent = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ShopOrderStatusId = table.Column<Guid>(type: "uuid", nullable: true),
                    ShopDeliveryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ShopDiscountId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrders_ShopDeliveries_ShopDeliveryId",
                        column: x => x.ShopDeliveryId,
                        principalTable: "ShopDeliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopOrders_ShopDiscounts_ShopDiscountId",
                        column: x => x.ShopDiscountId,
                        principalTable: "ShopDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ShopOrders_ShopOrderStatuses_ShopOrderStatusId",
                        column: x => x.ShopOrderStatusId,
                        principalTable: "ShopOrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CmsComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorName = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    AuthorEmail = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IpAddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    CmsPageId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmsNewsItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    ParentCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", rowVersion: true, nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmsComments_CmsComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CmsComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmsComments_CmsNewsItems_CmsNewsItemId",
                        column: x => x.CmsNewsItemId,
                        principalTable: "CmsNewsItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CmsComments_CmsPages_CmsPageId",
                        column: x => x.CmsPageId,
                        principalTable: "CmsPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CmsComments_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductCategories_ShopCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ShopCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopProductCategories_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductOptions_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductPhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductPhotos_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductPropertyValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopProductPropertyId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductPropertyValues_ShopProductProperties_ShopProduct~",
                        column: x => x.ShopProductPropertyId,
                        principalTable: "ShopProductProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopProductPropertyValues_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductRelatedProducts",
                columns: table => new
                {
                    RelatedProductsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductRelatedProducts", x => new { x.RelatedProductsId, x.ShopProductId });
                    table.ForeignKey(
                        name: "FK_ShopProductRelatedProducts_ShopProducts_RelatedProductsId",
                        column: x => x.RelatedProductsId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopProductRelatedProducts_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorStepPropertyValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                    ConstructorOrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConstructorStepPropertyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConstructorStepPropertyAvailableValueId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorStepPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstructorStepPropertyValues_ConstructorOrders_Constructor~",
                        column: x => x.ConstructorOrderId,
                        principalTable: "ConstructorOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructorStepPropertyValues_ConstructorStepProperties_Con~",
                        column: x => x.ConstructorStepPropertyId,
                        principalTable: "ConstructorStepProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstructorStepPropertyValues_ConstructorStepPropertyAvaila~",
                        column: x => x.ConstructorStepPropertyAvailableValueId,
                        principalTable: "ConstructorStepPropertyAvailableValues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopOrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    ProductCode = table.Column<string>(type: "text", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    ShopOrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrderItems_ShopOrders_ShopOrderId",
                        column: x => x.ShopOrderId,
                        principalTable: "ShopOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopOrderItems_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ShopPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TransactionId = table.Column<string>(type: "text", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    ShopOrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopPaymentTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopPayments_ShopOrders_ShopOrderId",
                        column: x => x.ShopOrderId,
                        principalTable: "ShopOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopPayments_ShopPaymentTypes_ShopPaymentTypeId",
                        column: x => x.ShopPaymentTypeId,
                        principalTable: "ShopPaymentTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopProductOptionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    PriceModifier = table.Column<decimal>(type: "numeric", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ShopProductOptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductOptionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductOptionItems_ShopProductOptions_ShopProductOption~",
                        column: x => x.ShopProductOptionId,
                        principalTable: "ShopProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrderItemOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OptionName = table.Column<string>(type: "text", nullable: false),
                    OptionValue = table.Column<string>(type: "text", nullable: false),
                    PriceModifier = table.Column<decimal>(type: "numeric", nullable: true),
                    ShopOrderItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<int>(type: "integer", nullable: false),
                    BuiltIn = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrderItemOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrderItemOptions_ShopOrderItems_ShopOrderItemId",
                        column: x => x.ShopOrderItemId,
                        principalTable: "ShopOrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CmsCategories_Code",
                table: "CmsCategories",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsCategories_ParentCategoryId",
                table: "CmsCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsComments_CmsNewsItemId",
                table: "CmsComments",
                column: "CmsNewsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsComments_CmsPageId",
                table: "CmsComments",
                column: "CmsPageId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsComments_ParentCommentId",
                table: "CmsComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsComments_ShopProductId",
                table: "CmsComments",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsMenuItems_CmsMenuId",
                table: "CmsMenuItems",
                column: "CmsMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsMenuItems_CmsPageId",
                table: "CmsMenuItems",
                column: "CmsPageId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsMenuItems_ParentMenuItemId",
                table: "CmsMenuItems",
                column: "ParentMenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsMenus_Code",
                table: "CmsMenus",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsNewsItems_CmsCategoryId",
                table: "CmsNewsItems",
                column: "CmsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsNewsItems_CmsPhotoGalleryId",
                table: "CmsNewsItems",
                column: "CmsPhotoGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsNewsItems_Code",
                table: "CmsNewsItems",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsPages_CmsCategoryId",
                table: "CmsPages",
                column: "CmsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsPages_CmsPhotoGalleryId",
                table: "CmsPages",
                column: "CmsPhotoGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_CmsPages_Code",
                table: "CmsPages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsPhotoGalleries_Code",
                table: "CmsPhotoGalleries",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsPhotos_CmsPhotoGalleryId",
                table: "CmsPhotos",
                column: "CmsPhotoGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepProperties_ConstructorStepId",
                table: "ConstructorStepProperties",
                column: "ConstructorStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepProperties_ConstructorStepPropertyGroupId",
                table: "ConstructorStepProperties",
                column: "ConstructorStepPropertyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepProperties_ConstructorStepPropertyTypeId",
                table: "ConstructorStepProperties",
                column: "ConstructorStepPropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepPropertyAvailableValues_ConstructorStepPrope~",
                table: "ConstructorStepPropertyAvailableValues",
                column: "ConstructorStepPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepPropertyValues_ConstructorOrderId",
                table: "ConstructorStepPropertyValues",
                column: "ConstructorOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepPropertyValues_ConstructorStepPropertyAvaila~",
                table: "ConstructorStepPropertyValues",
                column: "ConstructorStepPropertyAvailableValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructorStepPropertyValues_ConstructorStepPropertyId",
                table: "ConstructorStepPropertyValues",
                column: "ConstructorStepPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCategories_ParentCategoryId",
                table: "ShopCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopDiscounts_ShopDiscountTypeId",
                table: "ShopDiscounts",
                column: "ShopDiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrderItemOptions_ShopOrderItemId",
                table: "ShopOrderItemOptions",
                column: "ShopOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrderItems_ShopOrderId",
                table: "ShopOrderItems",
                column: "ShopOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrderItems_ShopProductId",
                table: "ShopOrderItems",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_OrderNumber",
                table: "ShopOrders",
                column: "OrderNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShopDeliveryId",
                table: "ShopOrders",
                column: "ShopDeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShopDiscountId",
                table: "ShopOrders",
                column: "ShopDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShopOrderStatusId",
                table: "ShopOrders",
                column: "ShopOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPayments_ShopOrderId",
                table: "ShopPayments",
                column: "ShopOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopPayments_ShopPaymentTypeId",
                table: "ShopPayments",
                column: "ShopPaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductCategories_CategoryId",
                table: "ShopProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductCategories_ShopProductId",
                table: "ShopProductCategories",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductOptionItems_ShopProductOptionId",
                table: "ShopProductOptionItems",
                column: "ShopProductOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductOptions_ShopProductId",
                table: "ShopProductOptions",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductPhotos_ShopProductId",
                table: "ShopProductPhotos",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductProperties_ShopProductPropertyGroupId",
                table: "ShopProductProperties",
                column: "ShopProductPropertyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductPropertyValues_ShopProductId",
                table: "ShopProductPropertyValues",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductPropertyValues_ShopProductPropertyId",
                table: "ShopProductPropertyValues",
                column: "ShopProductPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductRelatedProducts_ShopProductId",
                table: "ShopProductRelatedProducts",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_Code",
                table: "ShopProducts",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_ShopProductVendorId",
                table: "ShopProducts",
                column: "ShopProductVendorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CmsComments");

            migrationBuilder.DropTable(
                name: "CmsMenuItems");

            migrationBuilder.DropTable(
                name: "CmsPhotos");

            migrationBuilder.DropTable(
                name: "ConstructorStepPropertyValues");

            migrationBuilder.DropTable(
                name: "ShopOrderItemOptions");

            migrationBuilder.DropTable(
                name: "ShopPayments");

            migrationBuilder.DropTable(
                name: "ShopProductCategories");

            migrationBuilder.DropTable(
                name: "ShopProductOptionItems");

            migrationBuilder.DropTable(
                name: "ShopProductPhotos");

            migrationBuilder.DropTable(
                name: "ShopProductPropertyValues");

            migrationBuilder.DropTable(
                name: "ShopProductRelatedProducts");

            migrationBuilder.DropTable(
                name: "CmsNewsItems");

            migrationBuilder.DropTable(
                name: "CmsMenus");

            migrationBuilder.DropTable(
                name: "CmsPages");

            migrationBuilder.DropTable(
                name: "ConstructorOrders");

            migrationBuilder.DropTable(
                name: "ConstructorStepPropertyAvailableValues");

            migrationBuilder.DropTable(
                name: "ShopOrderItems");

            migrationBuilder.DropTable(
                name: "ShopPaymentTypes");

            migrationBuilder.DropTable(
                name: "ShopCategories");

            migrationBuilder.DropTable(
                name: "ShopProductOptions");

            migrationBuilder.DropTable(
                name: "ShopProductProperties");

            migrationBuilder.DropTable(
                name: "CmsCategories");

            migrationBuilder.DropTable(
                name: "CmsPhotoGalleries");

            migrationBuilder.DropTable(
                name: "ConstructorStepProperties");

            migrationBuilder.DropTable(
                name: "ShopOrders");

            migrationBuilder.DropTable(
                name: "ShopProducts");

            migrationBuilder.DropTable(
                name: "ShopProductPropertyGroups");

            migrationBuilder.DropTable(
                name: "ConstructorStepPropertyGroups");

            migrationBuilder.DropTable(
                name: "ConstructorStepPropertyTypes");

            migrationBuilder.DropTable(
                name: "ConstructorSteps");

            migrationBuilder.DropTable(
                name: "ShopDeliveries");

            migrationBuilder.DropTable(
                name: "ShopDiscounts");

            migrationBuilder.DropTable(
                name: "ShopOrderStatuses");

            migrationBuilder.DropTable(
                name: "ShopProductVendors");

            migrationBuilder.DropTable(
                name: "ShopDiscountTypes");
        }
    }
}
