﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ERespondent
{
    class ConnectionDB
    {
        private SqlConnection _connectionMain;
        private StringBuilder _result;
        private ConnectionStringSettings _settings;

        public ConnectionDB()
        {

        }

        /// <summary>
        /// Метод, устанавливающий соединение с БД. Строку подключения берет из app.config
        /// </summary>
        public SqlConnection CreateConnection()
        {
            SqlConnection _connectionMain=null;
            //берем из конфига строку подключения
            _settings = ConfigurationManager.ConnectionStrings["ERConn"];
            _result = new StringBuilder();
            try
            {
                if (_settings != null)
                {
                    _connectionMain = new SqlConnection();
                    _connectionMain.ConnectionString = _settings.ConnectionString;
                    _connectionMain.Open();
                    _result.Append("Состояние подключения: " + _connectionMain.State + "; " +
                             "Источник данных: " + _connectionMain.DataSource + "; " +
                             "Версия сервера: " + _connectionMain.ServerVersion);
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("При установлении соединения с SQL Server произошла ошибка, связанная" +
                    " с сетью или с определенным экземпляром. Сервер не найден или недоступен. Убедитесь, что" +
                    " имя экземпляра указано правильно и что на SQL Server разрешены удаленные соединения.");
                _connectionMain.Dispose();                  
            }                                                   
            return _connectionMain;
        }

        /// <summary>
        /// Закрытие соединения
        /// </summary>
        public void Close()
        {
            _connectionMain.Close();
        }


    }
}
