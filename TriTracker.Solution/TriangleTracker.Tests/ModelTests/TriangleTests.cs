using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void GetSideOne_GivingTheFirstSideValue_SideOne()
    {
      Triangle triangle = new Triangle(3, 6, 9);
      Assert.AreEqual(3, triangle.GetSideOne());
      Assert.AreEqual(6, triangle.GetSideTwo());
      Assert.AreEqual(9, triangle.GetSideThree());
    }

    [TestMethod]
    public void SetSideOne_SettingSideOne_Set()
    {
      Triangle triangle = new Triangle(3, 6, 9);
      triangle.SetSideOne(7);
      Assert.AreEqual(7, triangle.GetSideOne());
    }

    [TestMethod]
    public void CheckSideEquality_true()
    {
      Triangle triangle = new Triangle(9, 9, 9);
      Assert.AreEqual(true, triangle.CheckAllSidesEqual());
    }

    [TestMethod]
    public void CheckSideEquality_false()
    {
      Triangle triangle = new Triangle(9, 9, 0);
      Assert.AreEqual(false, triangle.CheckAllSidesEqual());
    }
  }
}
