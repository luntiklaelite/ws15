namespace lodki
{
    using MySql.Data.EntityFramework;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbModel : DbContext
    {
        static DbModel instance;
        public static DbModel init()
        {
            if (instance == null)
                instance = new DbModel();
            return instance;
        }


        // Контекст настроен для использования строки подключения "Model" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "lodki.Model" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model" 
        // в файле конфигурации приложения.
        public DbModel()
            : base("Server=localhost;User ID=luntiklaelite;password=123456789;CharSet=utf8;database=lodki")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Accessory> accessoryes { get; set; }
         public virtual DbSet<Partner> partners { get; set; }
         public virtual DbSet<Fit> fits { get; set; }
         public virtual DbSet<Boat> boats { get; set; }
         public virtual DbSet<orderDetail> ordDetails { get; set; }
         public virtual DbSet<Order> orders { get; set; }
         public virtual DbSet<Customer> customers { get; set; }
         public virtual DbSet<SalePerson> salePersons { get; set; }
         public virtual DbSet<Contract> contracts { get; set; }
         public virtual DbSet<Invoice> invoices { get; set; }
         public virtual DbSet<User> users { get; set; }

    }

    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string login { get; set; }
        [Required]
        [MaxLength(50)]
        public string pass { get; set; }
        [Required]
        public DateTime lastLogin { get; set; }
        [Required]
        public DateTime lastPass { get; set; }
        [Required]
        public bool isAdmin { get; set; }
    }

    public class Accessory
    {
        [Key]
        public int accessory_id { get; set; }
        [Required]
        [MaxLength(40)]
        public string acc_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string acc_descr { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public double VAT { get; set; }
        [Required]
        public int inventory { get; set; }
        [Required]
        public int orderLevel { get; set; }
        [Required]
        public int orderBatch { get; set; }
        public Partner partner_id { get; set; }
    }
    public class Partner
    {
        [Key]
        public int partner_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        [Required]
        [MaxLength(50)]
        public string address { get; set; }
        [Required]
        [MaxLength(50)]
        public string city { get; set; }
    }
    public class Fit
    {
        [Key]
        public int fit_id { get; set; }
        [Required]
        public Accessory acce_id { get; set; }
        [Required]
        public Boat boat_id { get; set; }
    }
    public class Boat
    {
        [Key]
        public int boat_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string model { get; set; }
        [Required]
        [MaxLength(50)]
        public string boatType { get; set; }
        [Required]
        public int numb_of_rowers { get; set; }
        [Required]
        public int mast { get; set; }
        [Required]
        [MaxLength(50)]
        public string colour { get; set; }
        [Required]
        [MaxLength(50)]
        public string wood { get; set; }
        [Required]
        public double BasePrice { get; set; }
        [Required]
        public double VAT { get; set; }
    }
    public class orderDetail
    {
        [Key]
        public int detail_id { get; set; }
        [Required]
        public Accessory acce_id { get; set; }
        [Required]
        public Order order_id { get; set; }
    }
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public SalePerson saleperson_ { get; set; }
        [Required]
        public Customer customer_id { get; set; }
        [Required]
        public Boat boat_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string deliveryAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string city { get; set; }
        public Order()
        {
            saleperson_ = new SalePerson();
        }
    }
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string familyName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string org_name { get; set; }
        [Required]
        [MaxLength(50)]
        public string address { get; set; }
        [Required]
        [MaxLength(50)]
        public string city { get; set; }
        [Required]
        [MaxLength(50)]
        public string email { get; set; }
        [Required]
        [MaxLength(50)]
        public string phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string idNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string idDocName { get; set; }

    }
    public class SalePerson
    {
        [Key]
        public int saleperson_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string firstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string familyName { get; set; }

    }
    public class Contract
    {
        public enum prProccess
        {
            notStarted = 0,
            started = 1,
            twentyFive = 2,
            fifty = 3,
            seventyFive = 4,
            otdelka = 5,
            ready = 6

        }
        public string getProcName(prProccess pr)
        {
            if (pr == prProccess.started)
                return "Начато производство";
            if (pr == prProccess.notStarted)
                return "Работы не начаты";
            if (pr == prProccess.twentyFive)
                return "25% готовности";
            if (pr == prProccess.fifty)
                return "50% готовности";
            if (pr == prProccess.seventyFive)
                return "75% готовности";
            if (pr == prProccess.otdelka)
                return "Отделка лодки";
            if (pr == prProccess.ready)
                return "Готово";
            return "unkown";
        }
        [Key]
        public int contract_id { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public double depPayed { get; set; }
        [Required]
        public Order order_id { get; set; }
        [Required]
        public double contractTotalPrice { get; set; }
        [Required]
        public int priceInclVAT { get; set; }
        [Required]
        public prProccess productProcces { get; set; }
    }
    public class Invoice
    {
        [Key]
        public int inv_id { get; set; }
        [Required]
        public Contract contr_id { get; set; }
        [Required]
        public int settled { get; set; }
        [Required]
        public double sum { get; set; }
        [Required]
        public double sumInclVAT { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}