namespace BrandNewDayEdificiosMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barrios",
                c => new
                    {
                        EdificioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Peligro = c.Int(nullable: false),
                        Vigilante = c.String(),
                    })
                .PrimaryKey(t => t.EdificioId);
            
            CreateTable(
                "dbo.Edificios",
                c => new
                    {
                        BarrioId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.BarrioId)
                .ForeignKey("dbo.Barrios", t => t.BarrioId)
                .Index(t => t.BarrioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Edificios", "BarrioId", "dbo.Barrios");
            DropIndex("dbo.Edificios", new[] { "BarrioId" });
            DropTable("dbo.Edificios");
            DropTable("dbo.Barrios");
        }
    }
}
