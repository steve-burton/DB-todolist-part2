using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ToDoList
  {
    public class CategoryTest //: IDisposable
    {
      public CategoryTest()
      {
        DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo_test;Integrated Security=SSPI;";
      }

      [Fact]
      public void Test_CategoriesEmptyAtFirst()
      {
        int result = Category.GetAll().Count;

        Assert.Equal(0, result);
      }
    }

  }