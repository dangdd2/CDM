using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bag_models",
                columns: table => new
                {
                    bag_model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    point_of_purchase = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bag_models", x => x.bag_model_id);
                });

            migrationBuilder.CreateTable(
                name: "bag_panel_fonts",
                columns: table => new
                {
                    bag_panel_font_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    font_type = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bag_panel_fonts", x => x.bag_panel_font_id);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brand_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    brand_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brand_id);
                });

            migrationBuilder.CreateTable(
                name: "club_categories",
                columns: table => new
                {
                    club_category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    category_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_categories", x => x.club_category_id);
                });

            migrationBuilder.CreateTable(
                name: "club_hand",
                columns: table => new
                {
                    club_hand_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    club_hand_desc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_hand", x => x.club_hand_id);
                });

            migrationBuilder.CreateTable(
                name: "club_lofts_adjustment",
                columns: table => new
                {
                    club_lofts_adjustment_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    loft_adjustment_value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_lofts_adjustment", x => x.club_lofts_adjustment_id);
                });

            migrationBuilder.CreateTable(
                name: "club_shaft_flexs",
                columns: table => new
                {
                    club_shaft_flex_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    flex_value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_shaft_flexs", x => x.club_shaft_flex_id);
                });

            migrationBuilder.CreateTable(
                name: "club_shaft_lengths",
                columns: table => new
                {
                    club_shaft_length_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    length_value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_shaft_lengths", x => x.club_shaft_length_id);
                });

            migrationBuilder.CreateTable(
                name: "consumers",
                columns: table => new
                {
                    consumer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    primary_email = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumers", x => x.consumer_id);
                });

            migrationBuilder.CreateTable(
                name: "consumers_audit",
                columns: table => new
                {
                    audit_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    consumer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    primary_email = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumers_audit", x => x.audit_id);
                });

            migrationBuilder.CreateTable(
                name: "experience_location",
                columns: table => new
                {
                    experience_location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    location_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experience_location", x => x.experience_location_id);
                });

            migrationBuilder.CreateTable(
                name: "handicap_range",
                columns: table => new
                {
                    handicap_range_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    range = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_handicap_range", x => x.handicap_range_id);
                });

            migrationBuilder.CreateTable(
                name: "point_of_purchase",
                columns: table => new
                {
                    point_of_purchase_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    point_of_purchase = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_point_of_purchase", x => x.point_of_purchase_id);
                });

            migrationBuilder.CreateTable(
                name: "region",
                columns: table => new
                {
                    region_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    region_code = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    region_desc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_region", x => x.region_id);
                });

            migrationBuilder.CreateTable(
                name: "systems",
                columns: table => new
                {
                    system_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systems", x => x.system_id);
                });

            migrationBuilder.CreateTable(
                name: "model",
                columns: table => new
                {
                    model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_brand_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    model_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model", x => x.model_id);
                    table.ForeignKey(
                        name: "FK_model_brands_club_brand_id",
                        column: x => x.club_brand_id,
                        principalTable: "brands",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "club_category_types",
                columns: table => new
                {
                    club_category_types_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    category_type = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_category_types", x => x.club_category_types_id);
                    table.ForeignKey(
                        name: "FK_club_category_types_club_categories_club_category_id",
                        column: x => x.club_category_id,
                        principalTable: "club_categories",
                        principalColumn: "club_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "club_lies",
                columns: table => new
                {
                    club_lie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    lie_value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_lies", x => x.club_lie_id);
                    table.ForeignKey(
                        name: "FK_club_lies_club_categories_ClubCategoryId",
                        column: x => x.ClubCategoryId,
                        principalTable: "club_categories",
                        principalColumn: "club_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "club_lofts",
                columns: table => new
                {
                    club_loft_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    sort_order = table.Column<int>(type: "int", nullable: false),
                    loft_value = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club_lofts", x => x.club_loft_id);
                    table.ForeignKey(
                        name: "FK_club_lofts_club_categories_club_category_id",
                        column: x => x.club_category_id,
                        principalTable: "club_categories",
                        principalColumn: "club_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consumer_emails",
                columns: table => new
                {
                    consumer_email_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsumerMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    consumer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    email = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    source = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumer_emails", x => x.consumer_email_id);
                    table.ForeignKey(
                        name: "FK_consumer_emails_consumers_ConsumerMasterId",
                        column: x => x.ConsumerMasterId,
                        principalTable: "consumers",
                        principalColumn: "consumer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_emails_region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "region",
                        principalColumn: "region_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    address_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    address_line_1 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    address_line_2 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    address_line_3 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    city = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    country = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    state = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    system_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    zipcode = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.address_id);
                    table.ForeignKey(
                        name: "FK_addresses_systems_system_id",
                        column: x => x.system_id,
                        principalTable: "systems",
                        principalColumn: "system_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "golfer_profile",
                columns: table => new
                {
                    golfer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_hand_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClubLoftAdjustmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    consumer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    current_7iron_ball_flight = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    current_driver_ball_flight = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    current_driver_flex_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    current_iron_length_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    current_iron_lie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    desired_7iron_ball_flight = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    desired_driver_ball_flight = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    desired_driver_flex_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    driver_loft = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    handicap = table.Column<int>(type: "int", nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    rounds_per_month = table.Column<int>(type: "int", nullable: false),
                    typical_7iron_distance = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    typical_driver_distance = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_golfer_profile", x => x.golfer_profile_id);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_hand_club_hand_id",
                        column: x => x.club_hand_id,
                        principalTable: "club_hand",
                        principalColumn: "club_hand_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_lofts_adjustment_ClubLoftAdjustmentId",
                        column: x => x.ClubLoftAdjustmentId,
                        principalTable: "club_lofts_adjustment",
                        principalColumn: "club_lofts_adjustment_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_consumers_consumer_id",
                        column: x => x.consumer_id,
                        principalTable: "consumers",
                        principalColumn: "consumer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_shaft_flexs_current_driver_flex_id",
                        column: x => x.current_driver_flex_id,
                        principalTable: "club_shaft_flexs",
                        principalColumn: "club_shaft_flex_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_shaft_lengths_current_iron_length_id",
                        column: x => x.current_iron_length_id,
                        principalTable: "club_shaft_lengths",
                        principalColumn: "club_shaft_length_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_lies_current_iron_lie_id",
                        column: x => x.current_iron_lie_id,
                        principalTable: "club_lies",
                        principalColumn: "club_lie_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_shaft_flexs_desired_driver_flex_id",
                        column: x => x.desired_driver_flex_id,
                        principalTable: "club_shaft_flexs",
                        principalColumn: "club_shaft_flex_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_golfer_profile_club_lofts_driver_loft",
                        column: x => x.driver_loft,
                        principalTable: "club_lofts",
                        principalColumn: "club_loft_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consumer_opt_in",
                columns: table => new
                {
                    consumer_opt_in_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    taylormade_brand = table.Column<bool>(type: "bit", nullable: false),
                    ConsumerEmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    consumer_email_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    my_fitting_exp = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumer_opt_in", x => x.consumer_opt_in_id);
                    table.ForeignKey(
                        name: "FK_consumer_opt_in_consumer_emails_ConsumerEmailId",
                        column: x => x.ConsumerEmailId,
                        principalTable: "consumer_emails",
                        principalColumn: "consumer_email_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consumer_profile",
                columns: table => new
                {
                    consumer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    address_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    consumer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    phone_cell = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    phone_home = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    region_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumer_profile", x => x.consumer_profile_id);
                    table.ForeignKey(
                        name: "FK_consumer_profile_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_profile_consumers_consumer_id",
                        column: x => x.consumer_id,
                        principalTable: "consumers",
                        principalColumn: "consumer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_profile_region_region_id",
                        column: x => x.region_id,
                        principalTable: "region",
                        principalColumn: "region_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "retail_store",
                columns: table => new
                {
                    retail_store_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    billing_address = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    display_name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ConsumerMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    email = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    is_certified_location = table.Column<bool>(type: "bit", nullable: false),
                    is_fitting_location = table.Column<bool>(type: "bit", nullable: false),
                    is_premium_location = table.Column<bool>(type: "bit", nullable: false),
                    is_tm_studio = table.Column<bool>(type: "bit", nullable: false),
                    is_tmpl_location = table.Column<bool>(type: "bit", nullable: false),
                    leadrank = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    phone_fax = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    phone_office = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    shipto = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    store_hours = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    website = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_retail_store", x => x.retail_store_id);
                    table.ForeignKey(
                        name: "FK_retail_store_addresses_billing_address",
                        column: x => x.billing_address,
                        principalTable: "addresses",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_retail_store_consumers_ConsumerMasterId",
                        column: x => x.ConsumerMasterId,
                        principalTable: "consumers",
                        principalColumn: "consumer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_retail_store_region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "region",
                        principalColumn: "region_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "whats_in_the_bag",
                columns: table => new
                {
                    whats_in_the_bag_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    brand_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    club_category_type_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    loft = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    flex = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    shaft_length_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    deleted = table.Column<bool>(type: "bit", nullable: false),
                    face_lie_adjustment = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    face_loft_adjustment = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    favorite = table.Column<bool>(type: "bit", nullable: false),
                    golfer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    plan_to_purchase = table.Column<bool>(type: "bit", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whats_in_the_bag", x => x.whats_in_the_bag_id);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_brands_brand_id",
                        column: x => x.brand_id,
                        principalTable: "brands",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "club_categories",
                        principalColumn: "club_category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_category_types_club_category_type_id",
                        column: x => x.club_category_type_id,
                        principalTable: "club_category_types",
                        principalColumn: "club_category_types_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_lofts_loft",
                        column: x => x.loft,
                        principalTable: "club_lofts",
                        principalColumn: "club_loft_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_shaft_flexs_flex",
                        column: x => x.flex,
                        principalTable: "club_shaft_flexs",
                        principalColumn: "club_shaft_flex_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_shaft_lengths_shaft_length_id",
                        column: x => x.shaft_length_id,
                        principalTable: "club_shaft_lengths",
                        principalColumn: "club_shaft_length_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_lies_face_lie_adjustment",
                        column: x => x.face_lie_adjustment,
                        principalTable: "club_lies",
                        principalColumn: "club_lie_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_club_lofts_adjustment_face_loft_adjustment",
                        column: x => x.face_loft_adjustment,
                        principalTable: "club_lofts_adjustment",
                        principalColumn: "club_lofts_adjustment_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_golfer_profile_golfer_profile_id",
                        column: x => x.golfer_profile_id,
                        principalTable: "golfer_profile",
                        principalColumn: "golfer_profile_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_whats_in_the_bag_model_model_id",
                        column: x => x.model_id,
                        principalTable: "model",
                        principalColumn: "model_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consumer_bag_panel_campaigns",
                columns: table => new
                {
                    consumer_bag_panel_campaign_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    address_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bag_color = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    bag_model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    panel_font_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bag_top_quality = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    bag_usage = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    best_feature = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ConsumerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    consumer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    item_number = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    opt_in_brand = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    point_of_purchase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    status = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    text_line_1 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    text_line_2 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    text_line_3 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumer_bag_panel_campaigns", x => x.consumer_bag_panel_campaign_id);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_bag_models_bag_model_id",
                        column: x => x.bag_model_id,
                        principalTable: "bag_models",
                        principalColumn: "bag_model_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_bag_panel_fonts_panel_font_id",
                        column: x => x.panel_font_id,
                        principalTable: "bag_panel_fonts",
                        principalColumn: "bag_panel_font_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "consumers",
                        principalColumn: "consumer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_consumer_profile_consumer_profile_id",
                        column: x => x.consumer_profile_id,
                        principalTable: "consumer_profile",
                        principalColumn: "consumer_profile_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_bag_panel_campaigns_point_of_purchase_point_of_purchase",
                        column: x => x.point_of_purchase,
                        principalTable: "point_of_purchase",
                        principalColumn: "point_of_purchase_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "system_to_consumer_profile",
                columns: table => new
                {
                    system_to_consumer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    consumer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    system_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_to_consumer_profile", x => x.system_to_consumer_profile_id);
                    table.ForeignKey(
                        name: "FK_system_to_consumer_profile_consumer_profile_consumer_profile_id",
                        column: x => x.consumer_profile_id,
                        principalTable: "consumer_profile",
                        principalColumn: "consumer_profile_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_system_to_consumer_profile_systems_system_id",
                        column: x => x.system_id,
                        principalTable: "systems",
                        principalColumn: "system_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consumer_experiences",
                columns: table => new
                {
                    consumer_experience_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    address_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    consumer_profile_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    experience_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExperienceLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    location = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumer_experiences", x => x.consumer_experience_id);
                    table.ForeignKey(
                        name: "FK_consumer_experiences_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_experiences_consumer_profile_consumer_profile_id",
                        column: x => x.consumer_profile_id,
                        principalTable: "consumer_profile",
                        principalColumn: "consumer_profile_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_experiences_experience_location_ExperienceLocationId",
                        column: x => x.ExperienceLocationId,
                        principalTable: "experience_location",
                        principalColumn: "experience_location_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consumer_experiences_retail_store_location",
                        column: x => x.location,
                        principalTable: "retail_store",
                        principalColumn: "retail_store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_addresses_system_id",
                table: "addresses",
                column: "system_id");

            migrationBuilder.CreateIndex(
                name: "IX_club_category_types_club_category_id",
                table: "club_category_types",
                column: "club_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_club_lies_ClubCategoryId",
                table: "club_lies",
                column: "ClubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_club_lofts_club_category_id",
                table: "club_lofts",
                column: "club_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_address_id",
                table: "consumer_bag_panel_campaigns",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_bag_model_id",
                table: "consumer_bag_panel_campaigns",
                column: "bag_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_panel_font_id",
                table: "consumer_bag_panel_campaigns",
                column: "panel_font_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_ConsumerId",
                table: "consumer_bag_panel_campaigns",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_consumer_profile_id",
                table: "consumer_bag_panel_campaigns",
                column: "consumer_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_bag_panel_campaigns_point_of_purchase",
                table: "consumer_bag_panel_campaigns",
                column: "point_of_purchase");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_emails_ConsumerMasterId",
                table: "consumer_emails",
                column: "ConsumerMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_emails_RegionId",
                table: "consumer_emails",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_experiences_address_id",
                table: "consumer_experiences",
                column: "address_id",
                unique: true,
                filter: "[address_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_experiences_consumer_profile_id",
                table: "consumer_experiences",
                column: "consumer_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_experiences_ExperienceLocationId",
                table: "consumer_experiences",
                column: "ExperienceLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_experiences_location",
                table: "consumer_experiences",
                column: "location");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_opt_in_ConsumerEmailId",
                table: "consumer_opt_in",
                column: "ConsumerEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_address_id",
                table: "consumer_profile",
                column: "address_id",
                unique: true,
                filter: "[address_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_consumer_id",
                table: "consumer_profile",
                column: "consumer_id");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_region_id",
                table: "consumer_profile",
                column: "region_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_region_id_consumer_id",
                table: "consumer_profile",
                columns: new[] { "region_id", "consumer_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_consumers_primary_email",
                table: "consumers",
                column: "primary_email",
                unique: true,
                filter: "[primary_email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_club_hand_id",
                table: "golfer_profile",
                column: "club_hand_id");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_ClubLoftAdjustmentId",
                table: "golfer_profile",
                column: "ClubLoftAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_consumer_id",
                table: "golfer_profile",
                column: "consumer_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_current_driver_flex_id",
                table: "golfer_profile",
                column: "current_driver_flex_id");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_current_iron_length_id",
                table: "golfer_profile",
                column: "current_iron_length_id");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_current_iron_lie_id",
                table: "golfer_profile",
                column: "current_iron_lie_id");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_desired_driver_flex_id",
                table: "golfer_profile",
                column: "desired_driver_flex_id");

            migrationBuilder.CreateIndex(
                name: "IX_golfer_profile_driver_loft",
                table: "golfer_profile",
                column: "driver_loft");

            migrationBuilder.CreateIndex(
                name: "IX_model_club_brand_id",
                table: "model",
                column: "club_brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_retail_store_billing_address",
                table: "retail_store",
                column: "billing_address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_retail_store_ConsumerMasterId",
                table: "retail_store",
                column: "ConsumerMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_retail_store_RegionId",
                table: "retail_store",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_system_to_consumer_profile_consumer_profile_id",
                table: "system_to_consumer_profile",
                column: "consumer_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_system_to_consumer_profile_system_id",
                table: "system_to_consumer_profile",
                column: "system_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_brand_id",
                table: "whats_in_the_bag",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_category_id",
                table: "whats_in_the_bag",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_club_category_type_id",
                table: "whats_in_the_bag",
                column: "club_category_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_loft",
                table: "whats_in_the_bag",
                column: "loft");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_flex",
                table: "whats_in_the_bag",
                column: "flex");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_shaft_length_id",
                table: "whats_in_the_bag",
                column: "shaft_length_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_face_lie_adjustment",
                table: "whats_in_the_bag",
                column: "face_lie_adjustment");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_face_loft_adjustment",
                table: "whats_in_the_bag",
                column: "face_loft_adjustment");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_golfer_profile_id",
                table: "whats_in_the_bag",
                column: "golfer_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_whats_in_the_bag_model_id",
                table: "whats_in_the_bag",
                column: "model_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consumer_bag_panel_campaigns");

            migrationBuilder.DropTable(
                name: "consumer_experiences");

            migrationBuilder.DropTable(
                name: "consumer_opt_in");

            migrationBuilder.DropTable(
                name: "consumers_audit");

            migrationBuilder.DropTable(
                name: "handicap_range");

            migrationBuilder.DropTable(
                name: "system_to_consumer_profile");

            migrationBuilder.DropTable(
                name: "whats_in_the_bag");

            migrationBuilder.DropTable(
                name: "bag_models");

            migrationBuilder.DropTable(
                name: "bag_panel_fonts");

            migrationBuilder.DropTable(
                name: "point_of_purchase");

            migrationBuilder.DropTable(
                name: "experience_location");

            migrationBuilder.DropTable(
                name: "retail_store");

            migrationBuilder.DropTable(
                name: "consumer_emails");

            migrationBuilder.DropTable(
                name: "consumer_profile");

            migrationBuilder.DropTable(
                name: "club_category_types");

            migrationBuilder.DropTable(
                name: "golfer_profile");

            migrationBuilder.DropTable(
                name: "model");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "region");

            migrationBuilder.DropTable(
                name: "club_hand");

            migrationBuilder.DropTable(
                name: "club_lofts_adjustment");

            migrationBuilder.DropTable(
                name: "consumers");

            migrationBuilder.DropTable(
                name: "club_shaft_flexs");

            migrationBuilder.DropTable(
                name: "club_shaft_lengths");

            migrationBuilder.DropTable(
                name: "club_lies");

            migrationBuilder.DropTable(
                name: "club_lofts");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "systems");

            migrationBuilder.DropTable(
                name: "club_categories");
        }
    }
}
