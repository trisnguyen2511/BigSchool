namespace ThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(2,'Bussniess')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES(3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
