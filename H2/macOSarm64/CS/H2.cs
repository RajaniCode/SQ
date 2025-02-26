// using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

/*
% java --version
% java -cp "$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/H2-Maven-Jar/h2-1.4.193.jar" org.h2.tools.Console -baseDir $HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/H2-Base -properties $HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/H2-Base


# DLLList.txt
H2-Sign-with-Strong-Name/h2-1.4.193.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Beans.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Misc.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Util.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.XPath.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Charsets.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Naming.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.API.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Corba.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Remoting.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Bind.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Core.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Security.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Crypto.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Runtime.JNI.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.AWT.WinForms.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Jdbc.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.SwingAWT.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Parse.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Management.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Text.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Transform.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Media.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Tools.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.WebServices.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Reflection.dll
IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Runtime.dll


# DLLListUninstall.txt
h2-1.4.193
IKVM.OpenJDK.Beans
IKVM.OpenJDK.Misc
IKVM.OpenJDK.Util
IKVM.OpenJDK.XML.XPath
IKVM.OpenJDK.Charsets
IKVM.OpenJDK.Naming
IKVM.OpenJDK.XML.API
IKVM.OpenJDK.Corba
IKVM.OpenJDK.Remoting
IKVM.OpenJDK.XML.Bind
IKVM.OpenJDK.Core
IKVM.OpenJDK.Security
IKVM.OpenJDK.XML.Crypto
IKVM.Runtime.JNI
IKVM.AWT.WinForms
IKVM.OpenJDK.Jdbc
IKVM.OpenJDK.SwingAWT
IKVM.OpenJDK.XML.Parse
IKVM.OpenJDK.Management
IKVM.OpenJDK.Text
IKVM.OpenJDK.XML.Transform
IKVM.OpenJDK.Media
IKVM.OpenJDK.Tools
IKVM.OpenJDK.XML.WebServices
IKVM.Reflection
IKVM.Runtime

# H2.exe.config
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="url" value="jdbc:h2:tcp://localhost/sampledb"/>
    <add key="user" value="SA"/>
    <add key="password" value=""/>
  </appSettings>
</configuration>


# Terminal New Window
% cd $HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS

% sudo gacutil -il DLLList.txt

% csc H2.cs /reference:"$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/H2-Sign-with-Strong-Name/h2-1.4.193.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Beans.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Misc.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Util.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.XPath.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Charsets.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Naming.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.API.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Corba.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Remoting.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Bind.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Core.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Security.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Crypto.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Runtime.JNI.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.AWT.WinForms.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Jdbc.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.SwingAWT.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Parse.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Management.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Text.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.Transform.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Media.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.Tools.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.OpenJDK.XML.WebServices.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Reflection.dll;$HOME/Desktop/GitHub/SQL-1/H2/macOSarm64/CS/IKVM.NET/ikvm-7.2.4630.5/bin/IKVM.Runtime.dll;"

% mono H2.exe

% sudo gacutil -ul DLLListUninstall.txt
*/

// using System.Data.SqlClient;
// using MySql.Data.MySqlClient;
using java.sql;
// using org.hsqldb;

class DataAccessObject
{
    // private const string url = "jdbc:h2:tcp://localhost/sampledb";
    // private const string user = "SA";
    // private const string password = ""; 

    private Connection GetConnection() 
    {
        Connection conn = null;
        try 
        {
            string url = ConfigurationManager.AppSettings["url"];        
            string user = ConfigurationManager.AppSettings["user"]; 
            string password = ConfigurationManager.AppSettings["password"];
            // Registering the H2 driver
            org.h2.Driver h2Driver = new org.h2.Driver();
            DriverManager.registerDriver(h2Driver);
            conn = DriverManager.getConnection(url, user, password); //
        } catch (ConfigurationErrorsException e) {
             Console.WriteLine(e.Message);
        }
        return conn;
    }

    public void TestConnection()
    {
        try 
        {            
            Connection conn = GetConnection();
            Console.WriteLine("Connected to H2 successfully."); 
        }
        catch (SQLException e) 
        {
            e.printStackTrace();
        }    
    }

    public Dictionary<int, Dictionary<string, string>> GetData(String query) 
    {   
        Dictionary<int, Dictionary<string, string>> rows = new Dictionary<int, Dictionary<string, string>>();
        try
        {
            Connection conn = GetConnection();
            Console.WriteLine("Connected to H2 successfully.");
            Statement statement = conn.createStatement();
            ResultSet rs = statement.executeQuery("SELECT * FROM users;");            
            int rowCount = 0;            
            ResultSetMetaData meta = rs.getMetaData();
            while(rs.next()) 
            {
                int columnCount = meta.getColumnCount();
                Dictionary<string, string> columns = new Dictionary<string, string>();
                for (int i = 1; i <= columnCount; i++)
                {
                    string type = meta.getColumnClassName(i);
                    string key = meta.getColumnName(i);                        
                    string value = rs.getString(key);
                    columns.Add(key, value);
                }
                /*
	        foreach(KeyValuePair<string, string> kvp in columns) 
                {        	
                    Console.WriteLine(kvp.Key + ": " + kvp.Value);
                }
                Console.WriteLine("Number of Columns(s) = " + columns.Count);
                */
                rowCount++;
                rows.Add(rowCount, columns);            
            }
            /*
            foreach(KeyValuePair<int, Dictionary<string, string>> rowsEntry in rows) 
            {            	
                foreach(KeyValuePair<string, string> columnsEntry in rowsEntry.Value) 
                {            	
	            Console.WriteLine(columnsEntry.Key + ": " + columnsEntry.Value);
                }
            }
            Console.WriteLine("Number of Row(s) = " + rows.Count);
            */
	    Console.WriteLine();
        } 
        catch (SQLException e) 
        {
            e.printStackTrace();
        }
        return rows;
    }
}

class H2
{
    static void Main()
    {
	Console.WriteLine($"Environment.Version: {Environment.Version}");
        Console.WriteLine($"System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}\n");

        DataAccessObject dao = new DataAccessObject();
        // dao.TestConnection();
        StringBuilder selectQuery = new StringBuilder();
        // selectQuery.Append("Select * FROM users;");
        selectQuery.Append("SELECT id, username, login_date, login_time, created_at, updated_at FROM users;");
        Dictionary<int, Dictionary<string, string>> rows = dao.GetData(selectQuery.ToString());
        if (rows != null) 
        {
            int rowCount = rows.Count;
            Console.WriteLine("Number of Row(s) = " + rowCount);
            if (rowCount > 0) 
            {
                foreach(KeyValuePair<int, Dictionary<string, string>> rowsEntry in rows) 
                {            	
                    foreach(KeyValuePair<string, string> columnsEntry in rowsEntry.Value) 
                    {            	
	                Console.WriteLine(columnsEntry.Key + ": " + columnsEntry.Value);
                    }
                }  
            }
        }
    }
}


/*
## H2 ## Start Server
$ java -version
$ cd "E:\Working\SQL\H2\CS\IKVM.NET"
$ unzip ikvmbin-7.2.4630.5.zip
$ cd "E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin"
$ ./ikvm
$ cp "E:\Working\SQL\H2\H2\H2-Maven-Jar\h2-1.4.193.jar" "E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin"
$ ./ikvm -cp h2-1.4.193.jar org.h2.tools.Server -baseDir /e/Working/SQL/H2/CS/H2-Base -properties /e/Working/SQL/H2/CS/H2-Base

# http://192.168.56.1:8082/login.jsp?jsessionid=3ff8a8e81be0a077dc7a73cea0f9dd30
# JDBC URL: jdbc:h2:sampledb
# Test Connection
# Save

# Git Bash # cd
$ ./ikvm -cp h2-1.4.193.jar org.h2.tools.Shell -url "jdbc:h2:tcp://192.168.56.1:9092/sampledb" -user "sa"

SELECT H2VERSION() FROM DUAL;

DROP TABLE IF EXISTS users;
CREATE TABLE users
(
    -- id INT IDENTITY NOT NULL,
    -- VERSION 2.2.224 does not support comma between START and INCREMENT
    -- id INT GENERATED BY DEFAULT AS IDENTITY (START WITH 101, INCREMENT BY 1),
    -- Hence
    -- id INT GENERATED BY DEFAULT AS IDENTITY (START WITH 101 INCREMENT BY 1),
    -- PRIMARY KEY
    id INT GENERATED BY DEFAULT AS IDENTITY (START WITH 101 INCREMENT BY 1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL, 
    login_date DATE DEFAULT CURRENT_DATE,
    login_time TIME DEFAULT CURRENT_TIME,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,    
    CONSTRAINT pk_id PRIMARY KEY(id),
    CONSTRAINT idx_username UNIQUE(username)    
);
COMMIT;

SELECT * FROM users;

INSERT INTO users(username, login_date, login_time, created_at, updated_at)
VALUES('Foo', '2016-11-06', '10:49:35', '2016-11-06 10:49:35.0', '2016-11-06 10:49:35.0');
COMMIT;

SELECT * FROM users;

## H2 dll
$ ./ikvmc -target:library -version:1.4.193 h2-1.4.193.jar # E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\h2-1.4.193.dll

## H2 Sign with Strong Name
$ cd "E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name"
$ cp "E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\h2-1.4.193.dll" "E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name"
$ sn -k keyPair.snk 
$ ildasm h2-1.4.193.dll /out:h2-1.4.193.il 
$ cmd
E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name>"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ilasm.exe" h2-1.4.193.il /dll /key=keyPair.snk
E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name>exit
$ sn -v h2-1.4.193.dll
# $ gacutil -i h2-1.4.193.dll 

## gacutil -il H2 and IKVM DLLs
$ cd "E:\Working\SQL\H2\CS"
$ gacutil -il DLLList.txt

# Note DLLList.txt file contains the following list of (1 H2 and 26 IKVM) assemblies
E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name\h2-1.4.193.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Beans.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Misc.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Util.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.XPath.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Charsets.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Naming.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.API.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Corba.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Remoting.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Bind.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Core.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Security.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Crypto.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Runtime.JNI.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.AWT.WinForms.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Jdbc.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.SwingAWT.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Parse.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Management.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Text.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Transform.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Media.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Tools.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.WebServices.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Reflection.dll
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Runtime.dll

## GAC
C:\Windows\Microsoft.NET\assembly\GAC_MSIL

## csc H2.cs
$ csc H2.cs /reference:"E:\Working\SQL\H2\CS\H2-Sign-with-Strong-Name\h2-1.4.193.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Beans.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Misc.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Util.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.XPath.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Charsets.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Naming.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.API.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Corba.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Remoting.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Bind.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Core.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Security.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Crypto.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Runtime.JNI.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.AWT.WinForms.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Jdbc.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.SwingAWT.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Parse.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Management.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Text.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.Transform.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Media.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.Tools.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.OpenJDK.XML.WebServices.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Reflection.dll;
E:\Working\SQL\H2\CS\IKVM.NET\ikvm-7.2.4630.5\bin\IKVM.Runtime.dll;"

$ ./H2.exe

## gacutil -ul H2 and IKVM DLLs
$ gacutil -ul DLLListUninstall.txt

# Note 
# DLLListUninstall.txt file contains the following list of 1 h2 assembly name (h2-1.4.193) and 26 IKVM assembly names  to be uninstalled from GAC
h2-1.4.193
IKVM.OpenJDK.Beans
IKVM.OpenJDK.Misc
IKVM.OpenJDK.Util
IKVM.OpenJDK.XML.XPath
IKVM.OpenJDK.Charsets
IKVM.OpenJDK.Naming
IKVM.OpenJDK.XML.API
IKVM.OpenJDK.Corba
IKVM.OpenJDK.Remoting
IKVM.OpenJDK.XML.Bind
IKVM.OpenJDK.Core
IKVM.OpenJDK.Security
IKVM.OpenJDK.XML.Crypto
IKVM.Runtime.JNI
IKVM.AWT.WinForms
IKVM.OpenJDK.Jdbc
IKVM.OpenJDK.SwingAWT
IKVM.OpenJDK.XML.Parse
IKVM.OpenJDK.Management
IKVM.OpenJDK.Text
IKVM.OpenJDK.XML.Transform
IKVM.OpenJDK.Media
IKVM.OpenJDK.Tools
IKVM.OpenJDK.XML.WebServices
IKVM.Reflection
IKVM.Runtime
*/


// Credits
/*
https://h2database.com/
https://openjdk.org/
https://java.com/
https://dotnet.microsoft.com/
https://mono-project.com/
https://ikvm.org/
*/