namespace lodki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        accessory_id = c.Int(nullable: false, identity: true),
                        acc_name = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        acc_descr = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        price = c.Double(nullable: false),
                        VAT = c.Double(nullable: false),
                        inventory = c.Int(nullable: false),
                        orderLevel = c.Int(nullable: false),
                        orderBatch = c.Int(nullable: false),
                        partner_id_partner_id = c.Int(),
                    })
                .PrimaryKey(t => t.accessory_id)
                .ForeignKey("dbo.Partners", t => t.partner_id_partner_id)
                .Index(t => t.partner_id_partner_id);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        partner_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        address = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        city = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.partner_id);
            
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        boat_id = c.Int(nullable: false, identity: true),
                        model = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        boatType = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        numb_of_rowers = c.Int(nullable: false),
                        mast = c.Int(nullable: false),
                        colour = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        wood = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        BasePrice = c.Double(nullable: false),
                        VAT = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.boat_id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        contract_id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false, precision: 0),
                        depPayed = c.Double(nullable: false),
                        contractTotalPrice = c.Double(nullable: false),
                        priceInclVAT = c.Int(nullable: false),
                        productProcces = c.Int(nullable: false),
                        order_id_order_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.contract_id)
                .ForeignKey("dbo.Orders", t => t.order_id_order_id, cascadeDelete: true)
                .Index(t => t.order_id_order_id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        order_id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false, precision: 0),
                        deliveryAddress = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        city = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        boat_id_boat_id = c.Int(nullable: false),
                        customer_id_customer_id = c.Int(nullable: false),
                        saleperson__saleperson_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.order_id)
                .ForeignKey("dbo.Boats", t => t.boat_id_boat_id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.customer_id_customer_id, cascadeDelete: true)
                .ForeignKey("dbo.SalePersons", t => t.saleperson__saleperson_id, cascadeDelete: true)
                .Index(t => t.boat_id_boat_id)
                .Index(t => t.customer_id_customer_id)
                .Index(t => t.saleperson__saleperson_id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customer_id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        familyName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        org_name = c.String(nullable: false, unicode: false),
                        address = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        city = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        email = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        phone = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        idNumber = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        idDocName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.customer_id);
            
            CreateTable(
                "dbo.SalePersons",
                c => new
                    {
                        saleperson_id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        familyName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.saleperson_id);
            
            CreateTable(
                "dbo.Fits",
                c => new
                    {
                        fit_id = c.Int(nullable: false, identity: true),
                        acce_id_accessory_id = c.Int(nullable: false),
                        boat_id_boat_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.fit_id)
                .ForeignKey("dbo.Accessories", t => t.acce_id_accessory_id, cascadeDelete: true)
                .ForeignKey("dbo.Boats", t => t.boat_id_boat_id, cascadeDelete: true)
                .Index(t => t.acce_id_accessory_id)
                .Index(t => t.boat_id_boat_id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        inv_id = c.Int(nullable: false, identity: true),
                        settled = c.Int(nullable: false),
                        sum = c.Double(nullable: false),
                        sumInclVAT = c.Double(nullable: false),
                        date = c.DateTime(nullable: false, precision: 0),
                        contr_id_contract_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.inv_id)
                .ForeignKey("dbo.Contracts", t => t.contr_id_contract_id, cascadeDelete: true)
                .Index(t => t.contr_id_contract_id);
            
            CreateTable(
                "dbo.orderDetails",
                c => new
                    {
                        detail_id = c.Int(nullable: false, identity: true),
                        acce_id_accessory_id = c.Int(nullable: false),
                        order_id_order_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.detail_id)
                .ForeignKey("dbo.Accessories", t => t.acce_id_accessory_id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.order_id_order_id, cascadeDelete: true)
                .Index(t => t.acce_id_accessory_id)
                .Index(t => t.order_id_order_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        pass = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        lastLogin = c.DateTime(nullable: false, precision: 0),
                        lastPass = c.DateTime(nullable: false, precision: 0),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.orderDetails", "order_id_order_id", "dbo.Orders");
            DropForeignKey("dbo.orderDetails", "acce_id_accessory_id", "dbo.Accessories");
            DropForeignKey("dbo.Invoices", "contr_id_contract_id", "dbo.Contracts");
            DropForeignKey("dbo.Fits", "boat_id_boat_id", "dbo.Boats");
            DropForeignKey("dbo.Fits", "acce_id_accessory_id", "dbo.Accessories");
            DropForeignKey("dbo.Contracts", "order_id_order_id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "saleperson__saleperson_id", "dbo.SalePersons");
            DropForeignKey("dbo.Orders", "customer_id_customer_id", "dbo.Customers");
            DropForeignKey("dbo.Orders", "boat_id_boat_id", "dbo.Boats");
            DropForeignKey("dbo.Accessories", "partner_id_partner_id", "dbo.Partners");
            DropIndex("dbo.orderDetails", new[] { "order_id_order_id" });
            DropIndex("dbo.orderDetails", new[] { "acce_id_accessory_id" });
            DropIndex("dbo.Invoices", new[] { "contr_id_contract_id" });
            DropIndex("dbo.Fits", new[] { "boat_id_boat_id" });
            DropIndex("dbo.Fits", new[] { "acce_id_accessory_id" });
            DropIndex("dbo.Orders", new[] { "saleperson__saleperson_id" });
            DropIndex("dbo.Orders", new[] { "customer_id_customer_id" });
            DropIndex("dbo.Orders", new[] { "boat_id_boat_id" });
            DropIndex("dbo.Contracts", new[] { "order_id_order_id" });
            DropIndex("dbo.Accessories", new[] { "partner_id_partner_id" });
            DropTable("dbo.Users");
            DropTable("dbo.orderDetails");
            DropTable("dbo.Invoices");
            DropTable("dbo.Fits");
            DropTable("dbo.SalePersons");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Contracts");
            DropTable("dbo.Boats");
            DropTable("dbo.Partners");
            DropTable("dbo.Accessories");
        }
    }
}
