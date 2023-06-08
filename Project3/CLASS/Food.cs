using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Food
    {
        MyDB db = new MyDB();
        public bool InsertNewFood(string Food,int Price,MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO menu (monan, gia, hinhanh)" + "VALUES (@monan,@gia,@hinhanh)", db.GetConnection);

            command.Parameters.Add("@monan", SqlDbType.VarChar).Value = Food;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = Price;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = Picture.ToArray();

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool InsertNewFoodCost(string food,int meat,int seafood, int veget,int water)
        {
            SqlCommand command = new SqlCommand("INSERT INTO haophi (monan,thit,haisan,rau,nuoc) VALUES (@monan,@thit,@haisan,@rau,@nuoc)", db.GetConnection);
            command.Parameters.Add("@monan", SqlDbType.VarChar).Value = food;
            command.Parameters.Add("@thit", SqlDbType.VarChar).Value = meat;
            command.Parameters.Add("@haisan", SqlDbType.VarChar).Value = seafood;
            command.Parameters.Add("@rau", SqlDbType.VarChar).Value = veget;
            command.Parameters.Add("@nuoc", SqlDbType.VarChar).Value = water;
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable GetIngrediant()
        {
            SqlCommand command = new SqlCommand("SELECT thit,haisan,rau,nuoc FROM nguyenlieu WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool UpdateIngrediant(int meat,int seafood,int veget,int water)
        {
            SqlCommand command = new SqlCommand("UPDATE nguyenlieu SET thit = @meat, haisan = @seafood, rau = @veget, nuoc = @water WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@meat", SqlDbType.Int).Value = meat;
            command.Parameters.Add("@seafood", SqlDbType.Int).Value = seafood;
            command.Parameters.Add("@water", SqlDbType.Int).Value = water;
            command.Parameters.Add("@veget", SqlDbType.Int).Value = veget;
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool DeleteFood(string foodname)
        {
            SqlCommand command = new SqlCommand("DELETE FROM menu WHERE monan = @food", db.GetConnection);
            SqlCommand command1 = new SqlCommand("DELETE FROM haophi WHERE monan = @food", db.GetConnection);
            command.Parameters.Add("@food", SqlDbType.VarChar).Value = foodname;
            command1.Parameters.Add("@food", SqlDbType.VarChar).Value = foodname;
            db.openConnection();

            if((command.ExecuteNonQuery() == 1)&&(command1.ExecuteNonQuery()==1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getAllFood()
        {
            SqlCommand command = new SqlCommand("SELECT monan as 'Món Ăn',gia as 'Giá',hinhanh as 'Hình Ảnh' FROM menu", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getFoodCost(string foodname)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM haophi WHERE monan = @foodname", db.GetConnection);
            command.Parameters.Add("@foodname", SqlDbType.VarChar).Value = foodname;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateFoodCost(string ofoodName, int meat, int seafood, int veget, int water,string nfoodName)
        {
            SqlCommand command = new SqlCommand("UPDATE haophi SET monan = @nfoodName, thit = @meat, haisan = @seafood, rau = @veget, nuoc = @water WHERE monan = @ofoodName", db.GetConnection);
            command.Parameters.Add("@nfoodName", SqlDbType.VarChar).Value = nfoodName;
            command.Parameters.Add("@ofoodName", SqlDbType.VarChar).Value = ofoodName;
            command.Parameters.Add("@meat", SqlDbType.Int).Value = meat;
            command.Parameters.Add("@seafood", SqlDbType.Int).Value = seafood;
            command.Parameters.Add("@veget", SqlDbType.Int).Value = veget;
            command.Parameters.Add("@water", SqlDbType.Int).Value = water;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updateFood(string nFood, int Price, MemoryStream Picture,string oFood)
        {
            SqlCommand command = new SqlCommand("UPDATE menu SET monan = @monanmoi, gia = @gia, hinhanh = @hinhanh WHERE monan = @monancu", db.GetConnection);

            command.Parameters.Add("@monanmoi", SqlDbType.VarChar).Value = nFood;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = Price;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = Picture.ToArray();
            command.Parameters.Add("@monancu", SqlDbType.VarChar).Value = oFood;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool UpgradeIngrediantAfterOrder(string foodName, int foodCount)
        {
            DataTable Ingrediant = GetIngrediant();
            DataTable FoodCost = getFoodCost(foodName);
            int meat =  (int)Ingrediant.Rows[0][0] - (int)FoodCost.Rows[0][1] * foodCount;
            int seafood = (int)Ingrediant.Rows[0][1] - (int)FoodCost.Rows[0][2] * foodCount;
            int veget = (int)Ingrediant.Rows[0][2] - (int)FoodCost.Rows[0][3] * foodCount;
            int water = (int)Ingrediant.Rows[0][3] - (int)FoodCost.Rows[0][4] * foodCount;

            if (meat < 0 || seafood < 0 || veget < 0 || water < 0)
            {
                return false;
            }
            else
            {
                UpdateIngrediant(meat, seafood, veget, water);
                return true;
            }
        }
        public int GetNumberOfPlate(string foodName)
        {
            DataTable Ingrediant = GetIngrediant();
            DataTable FoodCost = getFoodCost(foodName);
            int NumberOfPlate = 0;
            for(int i = 1; i < 5;i++)
            {
                if((int)FoodCost.Rows[0][i] == 0)
                {
                    continue;
                }
                else
                {
                    int tempN = (int)Ingrediant.Rows[0][i - 1] / (int)FoodCost.Rows[0][i];
                    if(NumberOfPlate == 0)
                    {
                        NumberOfPlate = tempN;
                    }
                    else
                    {
                        if (NumberOfPlate > tempN)
                        {
                            NumberOfPlate = tempN;
                        }
                    }
                }
            }
            return NumberOfPlate;
        }
        public DataTable getRequest(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
