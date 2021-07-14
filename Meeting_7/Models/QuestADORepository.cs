using Meeting_7.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Meeting_7.Models
{
    public class QuestADORepository : IQuestList<Quest>
    {
        private string connStr;
        public QuestADORepository()
        {
            connStr = ConfigurationManager.ConnectionStrings["questsDb"].ConnectionString;
        }

        public void Create(Quest item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddQuest", connection);
                    command.Parameters.Add("@title", SqlDbType.NVarChar, 100).Value = item.Title;
                    command.Parameters.Add("@description", SqlDbType.NVarChar, 255).Value = item.Description;
                    command.Parameters.Add("@imagePath", SqlDbType.NVarChar).Value = item.ImagePath;
                    command.Parameters.Add("@difficulty", SqlDbType.Int).Value = item.Difficulty;
                    command.Parameters.Add("@size", SqlDbType.NVarChar, 10).Value = item.Size;
                    command.Parameters.Add("@time", SqlDbType.Int).Value = item.Time;
                    command.Parameters.Add("@longDescriptionHeader", SqlDbType.NVarChar).Value = item.LongDescriptionHeader;
                    command.Parameters.Add("@longDescription", SqlDbType.NVarChar).Value = item.LongDescription;
                    command.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                    item.Id = (int)command.Parameters["@Id"].Value; 
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quest> GetAll()
        {
            List<Quest> quests = new List<Quest>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Quests", connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Quest quest = new Quest();
                        quest.Id = row.Field<int>("Id");
                        quest.Title = row.Field<string>("Title");
                        quest.Description = row.Field<string>("Description");
                        quest.ImagePath = row.Field<string>("ImagePath");
                        quest.Difficulty = row.Field<int>("Difficulty");
                        quest.Size = row.Field<string>("Size");
                        quest.Time = row.Field<int>("Time");
                        quest.LongDescriptionHeader = row.Field<string>("LongDescriptionHeader");
                        quest.LongDescription = row.Field<string>("LongDescription");
                        quests.Add(quest);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return quests;
        }

        public Quest GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Quest Update(Quest item)
        {
            throw new NotImplementedException();
        }
    }
}