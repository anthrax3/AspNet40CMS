using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for DBConn
/// </summary>
public class DBConn
{
    //1.Database Connection 정보
    string connectionString = WebConfigurationManager.ConnectionStrings["ASPNET"].ConnectionString;
    public SqlConnection dbConn;

    //2.생성자를 이용하여 생성과 동시에 데이터 접속
    public DBConn()
    {
        dbConn = new SqlConnection(connectionString);
        dbConn.Open();
    }

    //3. DB 연결 닫기
    public void Close()
    {
        dbConn.Close();
    }

    //4. 연결 객체 반환 메서드
    public SqlConnection GetConn()
    {
        return dbConn;
    }
}