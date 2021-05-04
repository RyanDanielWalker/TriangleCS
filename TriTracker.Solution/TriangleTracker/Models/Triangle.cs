namespace TriangleTracker
{
  public class Triangle
  {
    private int _sideOne;
    private int _sideTwo;
    private int _sideThree;
    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      _sideOne = sideOne;
      _sideTwo = sideTwo;
      _sideThree = sideThree;
    }

    public int GetSideOne()
    {
      return _sideOne;
    }

    public void SetSideOne(int sideOne)
    {
      _sideOne = sideOne;
    }

    public int GetSideTwo()
    {
      return _sideTwo;
    }

    public int GetSideThree()
    {
      return _sideThree;
    }

    public bool CheckAllSidesEqual()
    {
      if (_sideOne == _sideTwo && _sideOne == _sideThree)
      {
        return true;
      }
      return false;
    }

  }
}