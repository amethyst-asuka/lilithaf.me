REM  Oracle.LinuxCompatibility.MySQL.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @7/22/2016 9:26:52 PM


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace Storage.MySql

''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `device_tree`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `device_tree` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT COMMENT 'integer uid for token query',
'''   `token` char(32) NOT NULL COMMENT 'md5 hash value of the hardward signature info',
'''   `device_name` varchar(128) DEFAULT NULL,
'''   `register_time` datetime NOT NULL,
'''   `note` tinytext,
'''   PRIMARY KEY (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `device_tree`
''' --
''' 
''' LOCK TABLES `device_tree` WRITE;
''' /*!40000 ALTER TABLE `device_tree` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `device_tree` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("device_tree", Database:="authorization_token")>
Public Class device_tree: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' integer uid for token query
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("uid"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property uid As Long
''' <summary>
''' md5 hash value of the hardward signature info
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("token"), NotNull, DataType(MySqlDbType.VarChar, "32")> Public Property token As String
    <DatabaseField("device_name"), DataType(MySqlDbType.VarChar, "128")> Public Property device_name As String
    <DatabaseField("register_time"), NotNull, DataType(MySqlDbType.DateTime)> Public Property register_time As Date
    <DatabaseField("note"), DataType(MySqlDbType.Text)> Public Property note As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `device_tree` (`token`, `device_name`, `register_time`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `device_tree` (`token`, `device_name`, `register_time`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `device_tree` WHERE `uid` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `device_tree` SET `uid`='{0}', `token`='{1}', `device_name`='{2}', `register_time`='{3}', `note`='{4}' WHERE `uid` = '{5}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, token, device_name, DataType.ToMySqlDateTimeString(register_time), note)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, token, device_name, DataType.ToMySqlDateTimeString(register_time), note)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, token, device_name, DataType.ToMySqlDateTimeString(register_time), note, uid)
    End Function
#End Region
End Class


End Namespace
