using Kata._6_kyu.IndexOf_Array_in_Array.src;
using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.IndexOf_Array_in_Array.test
{
    [TestFixture]
  public class IndexOfArrayInArrayTest
  {
    [Test]
    public void BasicTests()
    {
      var bigArray = new object[][] { [2,3], [7,2], [9,20], [1,2], [7,2], [45,4], [7,87], [4,5], [2,7], [6,32] };
      var searchFor = new object[] { 9, 20 };
      ClassicAssert.AreEqual(2, IndexOfArrayInArray.SearchArray(bigArray,searchFor));
      searchFor = [1, 12];
      ClassicAssert.AreEqual(-1, IndexOfArrayInArray.SearchArray(bigArray,searchFor));
      searchFor = [7, 2];
      ClassicAssert.AreEqual(1, IndexOfArrayInArray.SearchArray(bigArray, searchFor));
    }
    
    [Test]
    public void ExtendedTests()
    {
      var bigArray = new object[][] { [2,3], [7,2], [9,20], [1,2], [7,2], [45,4], [7,87], [4,5], [2,7], [6,32] };

      var searchFor = new object[] { 7, 87 };
      ClassicAssert.AreEqual(6, IndexOfArrayInArray.SearchArray(bigArray, searchFor));
      searchFor = [45, 4];
      ClassicAssert.AreEqual(5, IndexOfArrayInArray.SearchArray(bigArray, searchFor));
      
      searchFor = [3, 4, 5];
      ClassicAssert.Throws(typeof(Exception), delegate { IndexOfArrayInArray.SearchArray(bigArray, searchFor); },
      "Should throw error if query Array has length other than 2");
      
      searchFor = [9, 20];
      bigArray = [[1, 2],  [3, 4],  [5, 6, 7],  [8, 9]];
      ClassicAssert.Throws(typeof(Exception), delegate { IndexOfArrayInArray.SearchArray(bigArray, searchFor); },
        "Should throw exception if a sub-Array of arrayToSearch has length other than 2");
      
      bigArray = [["Name", "Bob"],  ["Surname", "Smith"],  ["Occupation", "Builder"]];
      searchFor = ["Occupation", "Builder"];
      ClassicAssert.AreEqual(2, IndexOfArrayInArray.SearchArray(bigArray, searchFor));
      
      searchFor = ["Name", "Dan"];
      ClassicAssert.AreEqual(-1, IndexOfArrayInArray.SearchArray(bigArray, searchFor));
    }
    
    [Test]
    public void RandomTests()
    {
      var rand = new Random();
      
      Func<object[][],object[],int> mySearchArray = delegate(object[][] arrayToSearch, object[] query)
      {
        for(var i=0;i<arrayToSearch.Length;i++)
        {      
          var isEqual = true;

          for(int j=0;j<query.Length;j++)
            if(arrayToSearch[i][j].ToString() != query[j].ToString())
              isEqual = false;
          
          if(isEqual)
            return i;
        }
        return -1;
      };
       
      var bigArray = new object[100][];
      for(int i = 0; i < 100; i++)
      {
        bigArray[i] = new object[2];
        bigArray[i][0] = rand.Next(1,15);
        bigArray[i][1] = rand.Next(1,15);
      }
      
      for(var r = 0; r < 25; r++)
      {
        var queryArray = new object[2];
        queryArray[0] = rand.Next(1,15);
        queryArray[1] = rand.Next(1,15);
        
        var expected = mySearchArray(bigArray, queryArray);
        ClassicAssert.AreEqual(expected, IndexOfArrayInArray.SearchArray(bigArray, queryArray));
      }
    }
  }
}