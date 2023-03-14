using ce100_hw1_hamzaeren_gencalioglu;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestProject1
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
     public void MergeSort_BestCase()
     {
            int[] WorstCaseInput = new int[10001];
            for (int i = 0; i < 10000; i++)
            {
                WorstCaseInput[i] = i;
            }
       
            int[] Exp = new int[10001];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }
            CollectionAssert.AreEqual(Class1.MergeSort(WorstCaseInput), Exp);


        }


    }
}