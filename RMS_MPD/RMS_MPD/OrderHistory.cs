using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RMS_MPD
{
    public class OrderHistory
    {
        public static List<OrderHistory> OrderHistoryList = new List<OrderHistory>();

        public static string Account_Number;
        public static string Payment_Method;
        public static string Discount = String.Empty;

        public string SocialID;
        public string Date;
        public string OrderDate;
        public string Category;
        public string Name;
        public string Price;
        public string Quantity;
        public byte[] Photo;
        public byte[] Signature;
        public byte[] Receipt;
        public string AccountNumber;
        public string PaymentMethod;
        public string Discounts;
        public string OrderID;
        public string Status;
        //Signature Receipt AccountNumber PaymentMethod Discounts OrderID Status
        public OrderHistory(string SocialID, string Date, string OrderDate, string Category, string Name, string Price, string Quantity,
            byte[] Photo, byte[] Signature, byte[] Receipt, string AccountNumber, string PaymentMethod, string Discounts, string OrderID, string Status)
        {
            this.SocialID = SocialID;
            this.Date = Date;
            this.OrderDate = OrderDate;
            this.Category = Category;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Photo = Photo;
            this.Signature = Signature;
            this.Receipt = Receipt;
            this.AccountNumber = AccountNumber;
            this.PaymentMethod = PaymentMethod;
            this.Discounts = Discounts;
            this.OrderID = OrderID;
            this.Status = Status;
        }
        public OrderHistory()
        {

        }
        public static void AddtoTable(OrderHistory order)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrderHistory.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into OrderHistoryTable (SocialID,Date,OrderDate,Category,Name,Price,Quantity,Photo,Signature,Receipt," +
                "AccountNumber,PaymentMethod,Discounts,OrderID,Status) " +
                "values (@SocialID,@Date,@OrderDate,@Category,@Name,@Price,@Quantity,@Photo,@Signature,@Receipt,@AccountNumber,@PaymentMethod" +
                ",@Discounts,@OrderID,@Status)", con);
            
            cmd.Parameters.AddWithValue("@SocialID", order.SocialID);
            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            cmd.Parameters.AddWithValue("@Signature", order.Signature);
            cmd.Parameters.AddWithValue("@Receipt", order.Receipt);
            cmd.Parameters.AddWithValue("@AccountNumber", order.AccountNumber);
            cmd.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod);
            cmd.Parameters.AddWithValue("@Discounts", order.Discounts);
            cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
            cmd.Parameters.AddWithValue("@Status", order.Status);
            cmd.Parameters.AddWithValue("@Date", order.Date);
            cmd.Parameters.AddWithValue("@Category", order.Category);
            cmd.Parameters.AddWithValue("@Name", order.Name);
            cmd.Parameters.AddWithValue("@Price", order.Price);
            cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
            cmd.Parameters.AddWithValue("@Photo", order.Photo);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void FillList()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrderHistory.mdf;Integrated Security=True");
            string sql = "select * from OrderHistoryTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            OrderHistoryList.Clear();

            while (dr.Read())
            {
                OrderHistory order = new OrderHistory();

                order.SocialID = dr["SocialID"].ToString();
                order.Date = dr["Date"].ToString();
                order.OrderDate = dr["OrderDate"].ToString();
                order.Category = dr["Category"].ToString();
                order.Name = dr["Name"].ToString();
                order.Price = dr["Price"].ToString();
                order.Quantity = dr["Quantity"].ToString();
                order.Photo = (byte[])dr["Photo"];
                order.Signature = (byte[])dr["Signature"];
                order.Receipt = (byte[])dr["Receipt"];
                order.AccountNumber = dr["AccountNumber"].ToString();
                order.PaymentMethod = dr["PaymentMethod"].ToString();
                order.Discounts = dr["Discounts"].ToString();
                order.OrderID = dr["OrderID"].ToString();
                order.Status = dr["Status"].ToString();

                OrderHistoryList.Add(order);
            }
            con.Close();
        }
    }
}
