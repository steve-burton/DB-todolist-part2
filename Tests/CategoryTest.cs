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

      [Fact]
      public void Test_Equal_ReturnsTrueForSameName()
      {
        Category firstCategory = new Category("Household chores");
        Category secondCategory = new Category("Household chores");

        Assert.Equal(firstCategory, secondCategory);
      }

      [Fact]
      public void Test_Save_SavesCategoryToDatabase()
      {
        Category testCategory = new Category("Household chores");
        testCategory.Save();

        List<Category> result = Category.GetAll();
        List<Category> testList = new List<Category>{testCategory};

        Assert.Equal(testList, result);
      }
    }

  }
