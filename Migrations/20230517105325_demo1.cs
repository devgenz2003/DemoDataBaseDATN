using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assgiment_CSharp5.Migrations
{
    public partial class demo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    IDAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.IDAddress);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    IDCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.IDCategory);
                });

            migrationBuilder.CreateTable(
                name: "Color_Product",
                columns: table => new
                {
                    IDColor_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color_Product", x => x.IDColor_Product);
                });

            migrationBuilder.CreateTable(
                name: "Coupons_Partner",
                columns: table => new
                {
                    IDCoupons_Partner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons_Partner", x => x.IDCoupons_Partner);
                });

            migrationBuilder.CreateTable(
                name: "Favorites_List",
                columns: table => new
                {
                    IDFavorites_List = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites_List", x => x.IDFavorites_List);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    IDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDPersonnel = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.IDImages);
                });

            migrationBuilder.CreateTable(
                name: "Material_Product",
                columns: table => new
                {
                    IDMaterial_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material_Product", x => x.IDMaterial_Product);
                });

            migrationBuilder.CreateTable(
                name: "Membership_Level",
                columns: table => new
                {
                    IDMembership_Level = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership_Level", x => x.IDMembership_Level);
                });

            migrationBuilder.CreateTable(
                name: "Producer_Product",
                columns: table => new
                {
                    IDProducer_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Producer_ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer_ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer_ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer_ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer_Product", x => x.IDProducer_Product);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    IDReviews = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.IDReviews);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IDPersonnel = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "Size_Product",
                columns: table => new
                {
                    IDSize_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size_Product", x => x.IDSize_Product);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDetail",
                columns: table => new
                {
                    IDCategoryDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDetail", x => x.IDCategoryDetail);
                    table.ForeignKey(
                        name: "FK_CategoryDetail_Category_IDCategoryDetail",
                        column: x => x.IDCategoryDetail,
                        principalTable: "Category",
                        principalColumn: "IDCategory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partner",
                columns: table => new
                {
                    IDPartner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCoupons_Partner = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner", x => x.IDPartner);
                    table.ForeignKey(
                        name: "FK_Partner_Coupons_Partner_IDPartner",
                        column: x => x.IDPartner,
                        principalTable: "Coupons_Partner",
                        principalColumn: "IDCoupons_Partner",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    IDPersonnel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleIDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.IDPersonnel);
                    table.ForeignKey(
                        name: "FK_Personnel_Role_RoleIDRole",
                        column: x => x.RoleIDRole,
                        principalTable: "Role",
                        principalColumn: "IDRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceCeiling = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IDColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProducer_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMaterial_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDComboDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCategoryDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDOrdelDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDBillDetails = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCoupons = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewsIDReviews = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Product_Reviews_ReviewsIDReviews",
                        column: x => x.ReviewsIDReviews,
                        principalTable: "Reviews",
                        principalColumn: "IDReviews");
                    table.ForeignKey(
                        name: "FK_Product_Size_Product_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Size_Product",
                        principalColumn: "IDSize_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    IDPayments = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartnerIDPartner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDPartner = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.IDPayments);
                    table.ForeignKey(
                        name: "FK_Payments_Partner_PartnerIDPartner",
                        column: x => x.PartnerIDPartner,
                        principalTable: "Partner",
                        principalColumn: "IDPartner",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagesPersonnel",
                columns: table => new
                {
                    ImagesIDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonnelIDPersonnel = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesPersonnel", x => new { x.ImagesIDImages, x.PersonnelIDPersonnel });
                    table.ForeignKey(
                        name: "FK_ImagesPersonnel_Images_ImagesIDImages",
                        column: x => x.ImagesIDImages,
                        principalTable: "Images",
                        principalColumn: "IDImages",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagesPersonnel_Personnel_PersonnelIDPersonnel",
                        column: x => x.PersonnelIDPersonnel,
                        principalTable: "Personnel",
                        principalColumn: "IDPersonnel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDetailProduct",
                columns: table => new
                {
                    CategoryDetailIDCategoryDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDetailProduct", x => new { x.CategoryDetailIDCategoryDetail, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_CategoryDetailProduct_CategoryDetail_CategoryDetailIDCategoryDetail",
                        column: x => x.CategoryDetailIDCategoryDetail,
                        principalTable: "CategoryDetail",
                        principalColumn: "IDCategoryDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDetailProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Color_ProductProduct",
                columns: table => new
                {
                    Color_ProductIDColor_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color_ProductProduct", x => new { x.Color_ProductIDColor_Product, x.ProductIDProduct });
                    table.ForeignKey(
                        name: "FK_Color_ProductProduct_Color_Product_Color_ProductIDColor_Product",
                        column: x => x.Color_ProductIDColor_Product,
                        principalTable: "Color_Product",
                        principalColumn: "IDColor_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Color_ProductProduct_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagesProduct",
                columns: table => new
                {
                    ImagesIDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesProduct", x => new { x.ImagesIDImages, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_ImagesProduct_Images_ImagesIDImages",
                        column: x => x.ImagesIDImages,
                        principalTable: "Images",
                        principalColumn: "IDImages",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagesProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material_ProductProduct",
                columns: table => new
                {
                    Material_ProductIDMaterial_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material_ProductProduct", x => new { x.Material_ProductIDMaterial_Product, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_Material_ProductProduct_Material_Product_Material_ProductIDMaterial_Product",
                        column: x => x.Material_ProductIDMaterial_Product,
                        principalTable: "Material_Product",
                        principalColumn: "IDMaterial_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_ProductProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producer_ProductProduct",
                columns: table => new
                {
                    Producer_ProductIDProducer_Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer_ProductProduct", x => new { x.Producer_ProductIDProducer_Product, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_Producer_ProductProduct_Producer_Product_Producer_ProductIDProducer_Product",
                        column: x => x.Producer_ProductIDProducer_Product,
                        principalTable: "Producer_Product",
                        principalColumn: "IDProducer_Product",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producer_ProductProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressClient",
                columns: table => new
                {
                    AddresseIDAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressClient", x => new { x.AddresseIDAddress, x.ClientIDClient });
                    table.ForeignKey(
                        name: "FK_AddressClient_Address_AddresseIDAddress",
                        column: x => x.AddresseIDAddress,
                        principalTable: "Address",
                        principalColumn: "IDAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeBill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentsIDPayments = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.IDBill);
                    table.ForeignKey(
                        name: "FK_Bill_Address_IDAddress",
                        column: x => x.IDAddress,
                        principalTable: "Address",
                        principalColumn: "IDAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bill_Payments_PaymentsIDPayments",
                        column: x => x.PaymentsIDPayments,
                        principalTable: "Payments",
                        principalColumn: "IDPayments");
                });

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    IDBillDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetail", x => x.IDBillDetail);
                    table.ForeignKey(
                        name: "FK_BillDetail_Bill_IDBillDetail",
                        column: x => x.IDBillDetail,
                        principalTable: "Bill",
                        principalColumn: "IDBill",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Express_Delivery",
                columns: table => new
                {
                    IDExpress_Delivery = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sender_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delivery_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actual_Delivery_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delivery_Status = table.Column<int>(type: "int", nullable: false),
                    Shipping_Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payment_Status = table.Column<int>(type: "int", nullable: false),
                    BillIDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Express_Delivery", x => x.IDExpress_Delivery);
                    table.ForeignKey(
                        name: "FK_Express_Delivery_Bill_BillIDBill",
                        column: x => x.BillIDBill,
                        principalTable: "Bill",
                        principalColumn: "IDBill",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetailProduct",
                columns: table => new
                {
                    BillDetailsIDBillDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetailProduct", x => new { x.BillDetailsIDBillDetail, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_BillDetailProduct_BillDetail_BillDetailsIDBillDetail",
                        column: x => x.BillDetailsIDBillDetail,
                        principalTable: "BillDetail",
                        principalColumn: "IDBillDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetailProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identity_Card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDReviews = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMembership_Card = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Membership_LevelIDMembership_Level = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMembership_Level = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDFavorites_List = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Express_DeliveryIDExpress_Delivery = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IDClient);
                    table.ForeignKey(
                        name: "FK_Client_Express_Delivery_Express_DeliveryIDExpress_Delivery",
                        column: x => x.Express_DeliveryIDExpress_Delivery,
                        principalTable: "Express_Delivery",
                        principalColumn: "IDExpress_Delivery");
                    table.ForeignKey(
                        name: "FK_Client_Membership_Level_Membership_LevelIDMembership_Level",
                        column: x => x.Membership_LevelIDMembership_Level,
                        principalTable: "Membership_Level",
                        principalColumn: "IDMembership_Level",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFavorites_List",
                columns: table => new
                {
                    ClientsIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FavoritesIDFavorites_List = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFavorites_List", x => new { x.ClientsIDClient, x.FavoritesIDFavorites_List });
                    table.ForeignKey(
                        name: "FK_ClientFavorites_List_Client_ClientsIDClient",
                        column: x => x.ClientsIDClient,
                        principalTable: "Client",
                        principalColumn: "IDClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientFavorites_List_Favorites_List_FavoritesIDFavorites_List",
                        column: x => x.FavoritesIDFavorites_List,
                        principalTable: "Favorites_List",
                        principalColumn: "IDFavorites_List",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientImages",
                columns: table => new
                {
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagesIDImages = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientImages", x => new { x.ClientIDClient, x.ImagesIDImages });
                    table.ForeignKey(
                        name: "FK_ClientImages_Client_ClientIDClient",
                        column: x => x.ClientIDClient,
                        principalTable: "Client",
                        principalColumn: "IDClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientImages_Images_ImagesIDImages",
                        column: x => x.ImagesIDImages,
                        principalTable: "Images",
                        principalColumn: "IDImages",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientReviews",
                columns: table => new
                {
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewsIDReviews = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientReviews", x => new { x.ClientIDClient, x.ReviewsIDReviews });
                    table.ForeignKey(
                        name: "FK_ClientReviews_Client_ClientIDClient",
                        column: x => x.ClientIDClient,
                        principalTable: "Client",
                        principalColumn: "IDClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientReviews_Reviews_ReviewsIDReviews",
                        column: x => x.ReviewsIDReviews,
                        principalTable: "Reviews",
                        principalColumn: "IDReviews",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Membership_Card",
                columns: table => new
                {
                    IDMembership_Card = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipLevelIDMembership_Level = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMembership_Level = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership_Card", x => x.IDMembership_Card);
                    table.ForeignKey(
                        name: "FK_Membership_Card_Client_ClientIDClient",
                        column: x => x.ClientIDClient,
                        principalTable: "Client",
                        principalColumn: "IDClient");
                    table.ForeignKey(
                        name: "FK_Membership_Card_Membership_Level_MembershipLevelIDMembership_Level",
                        column: x => x.MembershipLevelIDMembership_Level,
                        principalTable: "Membership_Level",
                        principalColumn: "IDMembership_Level",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordel",
                columns: table => new
                {
                    IDOrdel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ClientIDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordel", x => x.IDOrdel);
                    table.ForeignKey(
                        name: "FK_Ordel_Client_ClientIDClient",
                        column: x => x.ClientIDClient,
                        principalTable: "Client",
                        principalColumn: "IDClient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    IDCoupons = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Coupon_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount_Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimum_Spend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Maximum_Discount_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembershipCardIDMembership_Card = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMembership_Card = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.IDCoupons);
                    table.ForeignKey(
                        name: "FK_Coupons_Membership_Card_MembershipCardIDMembership_Card",
                        column: x => x.MembershipCardIDMembership_Card,
                        principalTable: "Membership_Card",
                        principalColumn: "IDMembership_Card",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdelDetail",
                columns: table => new
                {
                    IDOrdeltDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrdelIDOrdel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdelDetail", x => x.IDOrdeltDetail);
                    table.ForeignKey(
                        name: "FK_OrdelDetail_Ordel_OrdelIDOrdel",
                        column: x => x.OrdelIDOrdel,
                        principalTable: "Ordel",
                        principalColumn: "IDOrdel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponsProduct",
                columns: table => new
                {
                    CouponsIDCoupons = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponsProduct", x => new { x.CouponsIDCoupons, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_CouponsProduct_Coupons_CouponsIDCoupons",
                        column: x => x.CouponsIDCoupons,
                        principalTable: "Coupons",
                        principalColumn: "IDCoupons",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponsProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Combo",
                columns: table => new
                {
                    IDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IDCoupons = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryIDCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrdelDetailIDOrdeltDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combo", x => x.IDCombo);
                    table.ForeignKey(
                        name: "FK_Combo_Category_CategoryIDCategory",
                        column: x => x.CategoryIDCategory,
                        principalTable: "Category",
                        principalColumn: "IDCategory");
                    table.ForeignKey(
                        name: "FK_Combo_OrdelDetail_OrdelDetailIDOrdeltDetail",
                        column: x => x.OrdelDetailIDOrdeltDetail,
                        principalTable: "OrdelDetail",
                        principalColumn: "IDOrdeltDetail");
                });

            migrationBuilder.CreateTable(
                name: "OrdelDetailProduct",
                columns: table => new
                {
                    OrdelDetailIDOrdeltDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdelDetailProduct", x => new { x.OrdelDetailIDOrdeltDetail, x.ProductsIDProduct });
                    table.ForeignKey(
                        name: "FK_OrdelDetailProduct_OrdelDetail_OrdelDetailIDOrdeltDetail",
                        column: x => x.OrdelDetailIDOrdeltDetail,
                        principalTable: "OrdelDetail",
                        principalColumn: "IDOrdeltDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdelDetailProduct_Product_ProductsIDProduct",
                        column: x => x.ProductsIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboCoupons",
                columns: table => new
                {
                    CombosIDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CouponsIDCoupons = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboCoupons", x => new { x.CombosIDCombo, x.CouponsIDCoupons });
                    table.ForeignKey(
                        name: "FK_ComboCoupons_Combo_CombosIDCombo",
                        column: x => x.CombosIDCombo,
                        principalTable: "Combo",
                        principalColumn: "IDCombo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboCoupons_Coupons_CouponsIDCoupons",
                        column: x => x.CouponsIDCoupons,
                        principalTable: "Coupons",
                        principalColumn: "IDCoupons",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboDetail",
                columns: table => new
                {
                    IDComboDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboIDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCombo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboDetail", x => x.IDComboDetail);
                    table.ForeignKey(
                        name: "FK_ComboDetail_Combo_ComboIDCombo",
                        column: x => x.ComboIDCombo,
                        principalTable: "Combo",
                        principalColumn: "IDCombo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboDetailProduct",
                columns: table => new
                {
                    ComboDetailIDComboDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboDetailProduct", x => new { x.ComboDetailIDComboDetail, x.ProductIDProduct });
                    table.ForeignKey(
                        name: "FK_ComboDetailProduct_ComboDetail_ComboDetailIDComboDetail",
                        column: x => x.ComboDetailIDComboDetail,
                        principalTable: "ComboDetail",
                        principalColumn: "IDComboDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboDetailProduct_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressClient_ClientIDClient",
                table: "AddressClient",
                column: "ClientIDClient");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ClientIDClient",
                table: "Bill",
                column: "ClientIDClient");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IDAddress",
                table: "Bill",
                column: "IDAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentsIDPayments",
                table: "Bill",
                column: "PaymentsIDPayments");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetailProduct_ProductsIDProduct",
                table: "BillDetailProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetailProduct_ProductsIDProduct",
                table: "CategoryDetailProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Express_DeliveryIDExpress_Delivery",
                table: "Client",
                column: "Express_DeliveryIDExpress_Delivery");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Membership_LevelIDMembership_Level",
                table: "Client",
                column: "Membership_LevelIDMembership_Level");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFavorites_List_FavoritesIDFavorites_List",
                table: "ClientFavorites_List",
                column: "FavoritesIDFavorites_List");

            migrationBuilder.CreateIndex(
                name: "IX_ClientImages_ImagesIDImages",
                table: "ClientImages",
                column: "ImagesIDImages");

            migrationBuilder.CreateIndex(
                name: "IX_ClientReviews_ReviewsIDReviews",
                table: "ClientReviews",
                column: "ReviewsIDReviews");

            migrationBuilder.CreateIndex(
                name: "IX_Color_ProductProduct_ProductIDProduct",
                table: "Color_ProductProduct",
                column: "ProductIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Combo_CategoryIDCategory",
                table: "Combo",
                column: "CategoryIDCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Combo_OrdelDetailIDOrdeltDetail",
                table: "Combo",
                column: "OrdelDetailIDOrdeltDetail");

            migrationBuilder.CreateIndex(
                name: "IX_ComboCoupons_CouponsIDCoupons",
                table: "ComboCoupons",
                column: "CouponsIDCoupons");

            migrationBuilder.CreateIndex(
                name: "IX_ComboDetail_ComboIDCombo",
                table: "ComboDetail",
                column: "ComboIDCombo");

            migrationBuilder.CreateIndex(
                name: "IX_ComboDetailProduct_ProductIDProduct",
                table: "ComboDetailProduct",
                column: "ProductIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_MembershipCardIDMembership_Card",
                table: "Coupons",
                column: "MembershipCardIDMembership_Card");

            migrationBuilder.CreateIndex(
                name: "IX_CouponsProduct_ProductsIDProduct",
                table: "CouponsProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Express_Delivery_BillIDBill",
                table: "Express_Delivery",
                column: "BillIDBill");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesPersonnel_PersonnelIDPersonnel",
                table: "ImagesPersonnel",
                column: "PersonnelIDPersonnel");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesProduct_ProductsIDProduct",
                table: "ImagesProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Material_ProductProduct_ProductsIDProduct",
                table: "Material_ProductProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Membership_Card_ClientIDClient",
                table: "Membership_Card",
                column: "ClientIDClient");

            migrationBuilder.CreateIndex(
                name: "IX_Membership_Card_MembershipLevelIDMembership_Level",
                table: "Membership_Card",
                column: "MembershipLevelIDMembership_Level");

            migrationBuilder.CreateIndex(
                name: "IX_Ordel_ClientIDClient",
                table: "Ordel",
                column: "ClientIDClient");

            migrationBuilder.CreateIndex(
                name: "IX_OrdelDetail_OrdelIDOrdel",
                table: "OrdelDetail",
                column: "OrdelIDOrdel");

            migrationBuilder.CreateIndex(
                name: "IX_OrdelDetailProduct_ProductsIDProduct",
                table: "OrdelDetailProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PartnerIDPartner",
                table: "Payments",
                column: "PartnerIDPartner");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_RoleIDRole",
                table: "Personnel",
                column: "RoleIDRole");

            migrationBuilder.CreateIndex(
                name: "IX_Producer_ProductProduct_ProductsIDProduct",
                table: "Producer_ProductProduct",
                column: "ProductsIDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ReviewsIDReviews",
                table: "Product",
                column: "ReviewsIDReviews");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressClient_Client_ClientIDClient",
                table: "AddressClient",
                column: "ClientIDClient",
                principalTable: "Client",
                principalColumn: "IDClient",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Client_ClientIDClient",
                table: "Bill",
                column: "ClientIDClient",
                principalTable: "Client",
                principalColumn: "IDClient",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Address_IDAddress",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Client_ClientIDClient",
                table: "Bill");

            migrationBuilder.DropTable(
                name: "AddressClient");

            migrationBuilder.DropTable(
                name: "BillDetailProduct");

            migrationBuilder.DropTable(
                name: "CategoryDetailProduct");

            migrationBuilder.DropTable(
                name: "ClientFavorites_List");

            migrationBuilder.DropTable(
                name: "ClientImages");

            migrationBuilder.DropTable(
                name: "ClientReviews");

            migrationBuilder.DropTable(
                name: "Color_ProductProduct");

            migrationBuilder.DropTable(
                name: "ComboCoupons");

            migrationBuilder.DropTable(
                name: "ComboDetailProduct");

            migrationBuilder.DropTable(
                name: "CouponsProduct");

            migrationBuilder.DropTable(
                name: "ImagesPersonnel");

            migrationBuilder.DropTable(
                name: "ImagesProduct");

            migrationBuilder.DropTable(
                name: "Material_ProductProduct");

            migrationBuilder.DropTable(
                name: "OrdelDetailProduct");

            migrationBuilder.DropTable(
                name: "Producer_ProductProduct");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "CategoryDetail");

            migrationBuilder.DropTable(
                name: "Favorites_List");

            migrationBuilder.DropTable(
                name: "Color_Product");

            migrationBuilder.DropTable(
                name: "ComboDetail");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Material_Product");

            migrationBuilder.DropTable(
                name: "Producer_Product");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Combo");

            migrationBuilder.DropTable(
                name: "Membership_Card");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Size_Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "OrdelDetail");

            migrationBuilder.DropTable(
                name: "Ordel");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Express_Delivery");

            migrationBuilder.DropTable(
                name: "Membership_Level");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Partner");

            migrationBuilder.DropTable(
                name: "Coupons_Partner");
        }
    }
}
