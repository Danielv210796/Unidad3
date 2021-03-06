﻿namespace PracticaSemanal1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProyect : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cines");
        }
    }
}
