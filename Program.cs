// See https://aka.ms/new-console-template for more information
using DataSource;
using Model;
using Dummy;
using Application;
using DataSqlite;


IDataSource dataSource = new DataSourceDummy();
// IDataSource dataSource = new DataSourceSqlite();

var app = new App(dataSource);
app.Run();


